﻿namespace Spreads

open System
open System.Collections
open System.Collections.Generic
open System.Diagnostics
open System.Runtime.InteropServices
open System.Threading.Tasks

open Spreads

// TODO see benchmark for ReadOnly. Reads are very slow while iterations are not affected (GetCursor() returns original cursor) in release mode. Optimize 
// reads of this wrapper either here by type-checking the source of the cursor and using direct methods on the source
// or make cursor thread-static and initialize it only once (now it is called on each method)

// TODO duplicate IReadOnlyOrderedMap methods as an instance method to avoid casting in F#. That will require ovverrides in all children or conflict
// check how it is used from C# (do tests in C# in general)

// TODO check thread safety of the default series implementation. Should we use ThreadLocal for caching cursors that are called via the interfaces?


[<AllowNullLiteral>]
[<Serializable>]
//[<AbstractClassAttribute>]
type BaseSeries internal() =
  // this is ugly, but rewriting the whole structure is uglier // TODO "proper" methods DI
  //static member internal DoInit() =
  static do
    let moduleInfo = 
      Reflection.Assembly.GetExecutingAssembly().GetTypes()
      |> Seq.find (fun t -> t.Name = "Initializer")
    //let ty = typeof<BaseSeries>
    let mi = moduleInfo.GetMethod("init", (Reflection.BindingFlags.Static ||| Reflection.BindingFlags.NonPublic) )
    mi.Invoke(null, [||]) |> ignore


and
  [<AllowNullLiteral>]
  [<Serializable>]
  [<AbstractClassAttribute>]
  Series<'K,'V when 'K : comparison>() as this =
    inherit BaseSeries()
    
    abstract GetCursor : unit -> ICursor<'K,'V>


    interface IEnumerable<KeyValuePair<'K, 'V>> with
      member this.GetEnumerator() = this.GetCursor() :> IEnumerator<KeyValuePair<'K, 'V>>
    interface System.Collections.IEnumerable with
      member this.GetEnumerator() = (this.GetCursor() :> System.Collections.IEnumerator)
    interface ISeries<'K, 'V> with
      member this.GetCursor() = this.GetCursor()
      member this.GetEnumerator() = this.GetCursor() :> IAsyncEnumerator<KVP<'K, 'V>>
      member this.IsIndexed with get() = this.GetCursor().Source.IsIndexed
      member this.SyncRoot with get() = this.GetCursor().Source.SyncRoot

    interface IReadOnlyOrderedMap<'K,'V> with
      member this.IsEmpty = not (this.GetCursor().MoveFirst())
      //member this.Count with get() = map.Count
      member this.First with get() = 
        let c = this.GetCursor()
        if c.MoveFirst() then c.Current else failwith "Series is empty"

      member this.Last with get() =
        let c = this.GetCursor()
        if c.MoveLast() then c.Current else failwith "Series is empty"

      member this.TryFind(k:'K, direction:Lookup, [<Out>] result: byref<KeyValuePair<'K, 'V>>) = 
        let c = this.GetCursor()
        if c.MoveAt(k, direction) then 
          result <- c.Current 
          true
        else failwith "Series is empty"

      member this.TryGetFirst([<Out>] res: byref<KeyValuePair<'K, 'V>>) = 
        try
          res <- (this :> IReadOnlyOrderedMap<'K,'V>).First
          true
        with
        | _ -> 
          res <- Unchecked.defaultof<KeyValuePair<'K, 'V>>
          false

      member this.TryGetLast([<Out>] res: byref<KeyValuePair<'K, 'V>>) = 
        try
          res <- (this :> IReadOnlyOrderedMap<'K,'V>).Last
          true
        with
        | _ -> 
          res <- Unchecked.defaultof<KeyValuePair<'K, 'V>>
          false

      member this.TryGetValue(k, [<Out>] value:byref<'V>) = 
        let c = this.GetCursor()
        if c.IsContinuous then
          c.TryGetValue(k, &value)
        else
          let v = ref Unchecked.defaultof<KVP<'K,'V>>
          let ok = c.MoveAt(k, Lookup.EQ)
          if ok then value <- c.CurrentValue else value <- Unchecked.defaultof<'V>
          ok

      member this.Item 
        with get k = 
          let ok, v = (this :> IReadOnlyOrderedMap<'K,'V>).TryGetValue(k)
          if ok then v else raise (KeyNotFoundException())

      member this.Keys 
        with get() =
          let c = this.GetCursor()
          seq {
            while c.MoveNext() do
              yield c.CurrentKey
          }

      member this.Values
        with get() =
          let c = this.GetCursor()
          seq {
            while c.MoveNext() do
              yield c.CurrentValue
          }


    /// Used for implement scalar operators which are essentially a map application
    static member private ScalarOperatorMap<'K,'V,'V2 when 'K : comparison>(source:Series<'K,'V>, mapFunc:Func<'V,'V2>) = 
      let mapF = ref mapFunc.Invoke
      let mapCursor = 
        {new CursorBind<'K,'V,'V2>(source.GetCursor) with
          override this.TryGetValue(key:'K, [<Out>] value: byref<KVP<'K,'V2>>): bool =
            // add works on any value, so must use TryGetValue instead of MoveAt
            let ok, value2 = this.InputCursor.TryGetValue(key)
            if ok then
              value <- KVP(key, mapF.Value(value2))
              true
            else false
          override this.TryUpdateNext(next:KVP<'K,'V>, [<Out>] value: byref<KVP<'K,'V2>>) : bool =
            value <- KVP(next.Key, mapF.Value(next.Value))
            true

          override this.TryUpdatePrevious(previous:KVP<'K,'V>, [<Out>] value: byref<KVP<'K,'V2>>) : bool =
            value <- KVP(previous.Key, mapF.Value(previous.Value))
            true
        }
      CursorSeries(fun _ -> mapCursor :> ICursor<'K,'V2>) :> Series<'K,'V2>

    static member (+) (source:Series<'K,int64>, addition:int64) : Series<'K,int64> = Series.ScalarOperatorMap(source, fun x -> x + addition)
    static member (~+) (source:Series<'K,int64>) : Series<'K,int64> = Series.ScalarOperatorMap(source, fun x -> x)
    static member (-) (source:Series<'K,int64>, subtraction:int64) : Series<'K,int64> = Series.ScalarOperatorMap(source, fun x -> x - subtraction)
    static member (~-) (source:Series<'K,int64>) : Series<'K,int64> = Series.ScalarOperatorMap(source, fun x -> -x)
    static member (*) (source:Series<'K,int64>, multiplicator:int64) : Series<'K,int64> = Series.ScalarOperatorMap(source, fun x -> x * multiplicator)
    static member (*) (multiplicator:int64,source:Series<'K,int64>) : Series<'K,int64> = Series.ScalarOperatorMap(source, fun x -> multiplicator * x)
    static member (/) (source:Series<'K,int64>, divisor:int64) : Series<'K,int64> = Series.ScalarOperatorMap(source, fun x -> x / divisor)
    static member (/) (numerator:int64,source:Series<'K,int64>) : Series<'K,int64> = Series.ScalarOperatorMap(source, fun x -> numerator / x)
    static member (%) (source:Series<'K,int64>, modulo:int64) : Series<'K,int64> = Series.ScalarOperatorMap(source, fun x -> x % modulo)
    static member ( ** ) (source:Series<'K,int64>, power:int64) : Series<'K,int64> = Series.ScalarOperatorMap(source, fun x -> raise (NotImplementedException("TODO Implement with fold, checked?")))
    static member (=) (source:Series<'K,int64>, other:int64) : Series<'K,bool> = Series.ScalarOperatorMap(source, fun x -> x = other)
    static member (>) (source:Series<'K,int64>, other:int64) : Series<'K,bool> = Series.ScalarOperatorMap(source, fun x -> x > other)
    static member (>) (other:int64, source:Series<'K,int64>) : Series<'K,bool> = Series.ScalarOperatorMap(source, fun x -> other > x)


    // TODO zip operators

    // TODO implement for other numeric types by Ctrl+H types
    static member (+) (source:Series<'K,float>, addition:float) : Series<'K,float> = Series.ScalarOperatorMap(source, fun x -> x + addition)
    static member (~+) (source:Series<'K,float>) : Series<'K,float> = Series.ScalarOperatorMap(source, fun x -> x)
    static member (-) (source:Series<'K,float>, subtraction:float) : Series<'K,float> = Series.ScalarOperatorMap(source, fun x -> x - subtraction)
    static member (~-) (source:Series<'K,float>) : Series<'K,float> = Series.ScalarOperatorMap(source, fun x -> -x)
    static member (*) (source:Series<'K,float>, multiplicator:float) : Series<'K,float> = Series.ScalarOperatorMap(source, fun x -> x * multiplicator)
    static member (*) (multiplicator:float,source:Series<'K,float>) : Series<'K,float> = Series.ScalarOperatorMap(source, fun x -> multiplicator * x)
    static member (/) (source:Series<'K,float>, divisor:float) : Series<'K,float> = Series.ScalarOperatorMap(source, fun x -> x / divisor)
    static member (/) (numerator:float,source:Series<'K,float>) : Series<'K,float> = Series.ScalarOperatorMap(source, fun x -> numerator / x)
    static member (%) (source:Series<'K,float>, modulo:float) : Series<'K,float> = Series.ScalarOperatorMap(source, fun x -> x % modulo)
    static member ( ** ) (source:Series<'K,float>, power:float) : Series<'K,float> = Series.ScalarOperatorMap(source, fun x -> x ** power)
    static member (>) (source:Series<'K,float>, other:float) : Series<'K,bool> = Series.ScalarOperatorMap(source, fun x -> x > other)
    //static member op_GreaterThan(source:Series<'K,float>, comparand:float) : Series<'K,bool> = Series.ScalarOperatorMap(source, fun x -> x > comparand)



and
  // TODO (perf) base Series() implements IROOM ineficiently, see comments in above type Series() implementation
  
  /// Wrap Series over ICursor
  [<AllowNullLiteral>]
  [<Serializable>]
  CursorSeries<'K,'V when 'K : comparison>(cursorFactory:unit->ICursor<'K,'V>) =
      inherit Series<'K,'V>()
      override this.GetCursor() = cursorFactory()


// I had an attempt to manually optimize callvirt and object allocation, both failed badly
// They are not needed, however, in most of the cases, e.g. iterations.
// see https://msdn.microsoft.com/en-us/library/ms973852.aspx
// ...the virtual and interface method call sites are monomorphic (e.g. per call site, the target method does not change over time), 
// so the combination of caching the virtual method and interface method dispatch mechanisms (the method table and interface map 
// pointers and entries) and spectacularly provident branch prediction enables the processor to do an unrealistically effective 
// job calling through these otherwise difficult-to-predict, data-dependent branches. In practice, a data cache miss on any of the 
// dispatch mechanism data, or a branch misprediction (be it a compulsory capacity miss or a polymorphic call site), can and will
//  slow down virtual and interface calls by dozens of cycles.
//
// Our benchmark confirms that the slowdown of .Repeat(), .ReadOnly(), .Map(...) and .Filter(...) is quite small 

and // TODO internal
  [<AbstractClassAttribute>]
  CursorBind<'K,'V,'V2 when 'K : comparison>(cursorFactory:unit->ICursor<'K,'V>) =
  
    let cursor = cursorFactory()

    // TODO make public property, e.g. for random walk generator we must throw if we try to init more than one
    // this is true for all "vertical" transformations, they start from a certain key and depend on the starting value
    // safe to call TryUpdateNext/Previous
    let mutable hasValidState = false
    member this.HasValidState with get() = hasValidState and set (v) = hasValidState <- v

    // TODO? add key type for the most general case
    // check if key types are not equal, in that case check if new values are sorted. On first 
    // unsorted value change output to Indexed

    //member val IsIndexed = false with get, set //source.IsIndexed
    /// By default, could move everywhere the source moves
    member val IsContinuous = cursor.IsContinuous with get, set

    /// Source series
    //member this.InputSource with get() = source
    member this.InputCursor with get() : ICursor<'K,'V> = cursor

    //abstract CurrentKey:'K with get
    //abstract CurrentValue:'V2 with get
    member val CurrentKey = Unchecked.defaultof<'K> with get, set
    member val CurrentValue = Unchecked.defaultof<'V2> with get, set
    member this.Current with get () = KVP(this.CurrentKey, this.CurrentValue)

    /// Stores current batch for a succesful batch move
    //abstract CurrentBatch : IReadOnlyOrderedMap<'K,'V2> with get
    member val CurrentBatch = Unchecked.defaultof<IReadOnlyOrderedMap<'K,'V2>> with get, set

    /// For every successful move of the inut coursor creates an output value. If direction is not EQ, continues moves to the direction 
    /// until the state is created
    abstract TryGetValue: key:'K * [<Out>] value: byref<KVP<'K,'V2>> -> bool // * direction: Lookup not needed here
    // this is the main method to transform input to output, other methods could be implemented via it


    /// Update state with a new value. Should be optimized for incremental update of the current state in custom implementations.
    abstract TryUpdateNext: next:KVP<'K,'V> * [<Out>] value: byref<KVP<'K,'V2>> -> bool
    override this.TryUpdateNext(next:KVP<'K,'V>, [<Out>] value: byref<KVP<'K,'V2>>) : bool =
      // recreate value from scratch
      this.TryGetValue(next.Key, &value)

    /// Update state with a previous value. Should be optimized for incremental update of the current state in custom implementations.
    abstract TryUpdatePrevious: previous:KVP<'K,'V> * [<Out>] value: byref<KVP<'K,'V2>> -> bool
    override this.TryUpdatePrevious(previous:KVP<'K,'V>, [<Out>] value: byref<KVP<'K,'V2>>) : bool =
      // recreate value from scratch
      this.TryGetValue(previous.Key, &value)

    /// If input and this cursor support batches, then process a batch and store it in CurrentBatch
    abstract TryUpdateNextBatch: nextBatch: IReadOnlyOrderedMap<'K,'V> * [<Out>] value: byref<IReadOnlyOrderedMap<'K,'V2>> -> bool  
    override this.TryUpdateNextBatch(nextBatch: IReadOnlyOrderedMap<'K,'V>, [<Out>] value: byref<IReadOnlyOrderedMap<'K,'V2>>) : bool =
  //    let map = SortedMap<'K,'V2>()
  //    let isFirst = ref true
  //    for kvp in nextBatch do
  //      if !isFirst then
  //        isFirst := false
  //        let ok, newKvp = this.TryGetValue(kvp.Key)
  //        if ok then map.AddLast(newKvp.Key, newKvp.Value)
  //      else
  //        let ok, newKvp = this.TryUpdateNext(kvp)
  //        if ok then map.AddLast(newKvp.Key, newKvp.Value)
  //    if map.size > 0 then 
  //      value <- map :> IReadOnlyOrderedMap<'K,'V2>
  //      true
  //    else false
      false

    member this.Reset() = 
      hasValidState <- false
      cursor.Reset()
    member this.Dispose() = 
      hasValidState <- false
      cursor.Dispose()

    interface IEnumerator<KVP<'K,'V2>> with    
      member this.Reset() = this.Reset()
      member x.MoveNext(): bool =
        if hasValidState then
          let mutable found = false
          while not found && x.InputCursor.MoveNext() do // NB! x.InputCursor.MoveNext() && not found // was stupid serious bug, order matters
            let ok, value = x.TryUpdateNext(x.InputCursor.Current)
            if ok then 
              found <- true
              x.CurrentKey <- value.Key
              x.CurrentValue <- value.Value
          if found then 
            //hasInitializedValue <- true
            true 
          else false
        else (x :> ICursor<'K,'V2>).MoveFirst()
      member this.Current with get(): KVP<'K, 'V2> = this.Current
      member this.Current with get(): obj = this.Current :> obj 
      member x.Dispose(): unit = x.Dispose()

    interface ICursor<'K,'V2> with
      member x.Current: KVP<'K,'V2> = KVP(x.CurrentKey, x.CurrentValue)
      member x.CurrentBatch: IReadOnlyOrderedMap<'K,'V2> = x.CurrentBatch
      member x.CurrentKey: 'K = x.CurrentKey
      member x.CurrentValue: 'V2 = x.CurrentValue
      member x.IsContinuous: bool = x.IsContinuous
      member x.MoveAt(index: 'K, direction: Lookup): bool = 
        if x.InputCursor.MoveAt(index, direction) then
          let ok, value = x.TryGetValue(x.InputCursor.CurrentKey)
          if ok then
            x.CurrentKey <- value.Key
            x.CurrentValue <- value.Value
            hasValidState <- true
            true
          else
            match direction with
            | Lookup.EQ -> false
            | Lookup.GE | Lookup.GT ->
              let mutable found = false
              while not found && x.InputCursor.MoveNext() do
                let ok, value = x.TryGetValue(x.InputCursor.CurrentKey)
                if ok then 
                  found <- true
                  x.CurrentKey <- value.Key
                  x.CurrentValue <- value.Value
              if found then 
                hasValidState <- true
                true 
              else false
            | Lookup.LE | Lookup.LT ->
              let mutable found = false
              while not found && x.InputCursor.MovePrevious() do
                let ok, value = x.TryGetValue(x.InputCursor.CurrentKey)
                if ok then
                  found <- true
                  x.CurrentKey <- value.Key
                  x.CurrentValue <- value.Value
              if found then 
                hasValidState <- true
                true 
              else false
            | _ -> failwith "wrong lookup value"
        else false
      
    
      member x.MoveFirst(): bool = 
        if x.InputCursor.MoveFirst() then
          let ok, value = x.TryGetValue(x.InputCursor.CurrentKey)
          if ok then
            x.CurrentKey <- value.Key
            x.CurrentValue <- value.Value
            hasValidState <- true
            true
          else
            let mutable found = false
            while not found && x.InputCursor.MoveNext() do
              let ok, value = x.TryGetValue(x.InputCursor.CurrentKey)
              if ok then 
                found <- true
                x.CurrentKey <- value.Key
                x.CurrentValue <- value.Value
            if found then 
              hasValidState <- true
              true 
            else false
        else false
    
      member x.MoveLast(): bool = 
        if x.InputCursor.MoveLast() then
          let ok, value = x.TryGetValue(x.InputCursor.CurrentKey)
          if ok then
            x.CurrentKey <- value.Key
            x.CurrentValue <- value.Value
            hasValidState <- true
            true
          else
            let mutable found = false
            while not found && x.InputCursor.MovePrevious() do
              let ok, value = x.TryGetValue(x.InputCursor.CurrentKey)
              if ok then
                found <- true
                x.CurrentKey <- value.Key
                x.CurrentValue <- value.Value
            if found then 
              hasValidState <- true
              true 
            else false
        else false

      member x.MovePrevious(): bool = 
        if hasValidState then
          let mutable found = false
          while not found && x.InputCursor.MovePrevious() do
            let ok, value = x.TryUpdatePrevious(x.InputCursor.Current)
            if ok then 
              found <- true
              x.CurrentKey <- value.Key
              x.CurrentValue <- value.Value
          if found then 
            hasValidState <- true
            true 
          else false
        else (x :> ICursor<'K,'V2>).MoveLast()
    
      member x.MoveNext(cancellationToken: Threading.CancellationToken): Task<bool> = 
        failwith "Not implemented yet"
      member x.MoveNextBatch(cancellationToken: Threading.CancellationToken): Task<bool> = 
        failwith "Not implemented yet"
    
      //member x.IsBatch with get() = x.IsBatch
      member x.Source: ISeries<'K,'V2> = CursorSeries<'K,'V2>((x :> ICursor<'K,'V2>).Clone) :> ISeries<'K,'V2>
      member x.TryGetValue(key: 'K, [<Out>] value: byref<'V2>): bool = 
        let ok, v = x.TryGetValue(key)
        value <- v.Value
        ok
    
      // TODO review + profile. for value types we could just return this
      member x.Clone(): ICursor<'K,'V2> =
        // run-time type of the instance, could be derived type
        let ty = x.GetType()
        let args = [|cursorFactory :> obj|]
        // TODO using Activator is a very bad sign, are we doing something wrong here?
        let clone = Activator.CreateInstance(ty, args) :?> ICursor<'K,'V2> // should not be called too often
        if hasValidState then clone.MoveAt(x.CurrentKey, Lookup.EQ) |> ignore
        //Debug.Assert(movedOk) // if current key is set then we could move to it
        clone


and // TODO internal
  [<AbstractClassAttribute>]
  CursorZip<'K,'V1,'V2,'R when 'K : comparison>(cursorFactoryL:unit->ICursor<'K,'V1>, cursorFactoryR:unit->ICursor<'K,'V2>) =
  
    let cursorL = cursorFactoryL()
    let cursorR = cursorFactoryR()
    let lIsAhead() = CursorHelper.lIsAhead cursorL cursorR
    // TODO comparer as a part of ICursor interface
    // if comparers are not equal then throw invaliOp
    let cmp = Comparer<'K>.Default 

    let mutable hasValidState = false

    member this.Comparer with get() = cmp
    member this.HasValidState with get() = hasValidState and set (v) = hasValidState <- v

    member val IsContinuous = cursorL.IsContinuous && cursorR.IsContinuous with get, set

    /// Source series
    member this.InputCursorL with get() : ICursor<'K,'V1> = cursorL
    member this.InputCursorR with get() : ICursor<'K,'V2> = cursorR

    member val CurrentKey = Unchecked.defaultof<'K> with get, set
    member val CurrentValue = Unchecked.defaultof<'R> with get, set
    member this.Current with get () = KVP(this.CurrentKey, this.CurrentValue)

    /// Stores current batch for a succesful batch move. Value is defined only after successful MoveNextBatch
    member val CurrentBatch = Unchecked.defaultof<IReadOnlyOrderedMap<'K,'R>> with get, set

    /// For every successful move of the inut coursor creates an output value. If direction is not EQ, continues moves to the direction 
    /// until the state is created
    abstract TryGetValue: key:'K * [<Out>] value: byref<KVP<'K,'R>> -> bool // * direction: Lookup not needed here
    // this is the main method to transform input to output, other methods could be implemented via it

    /// Update state with a new value. Should be optimized for incremental update of the current state in custom implementations.
    abstract TryUpdateNext: next:KVP<'K,ValueTuple<'V1,'V2>> * [<Out>] value: byref<KVP<'K,'R>> -> bool
    override this.TryUpdateNext(next:KVP<'K,ValueTuple<'V1,'V2>>, [<Out>] value: byref<KVP<'K,'R>>) : bool =
      // recreate value from scratch
      this.TryGetValue(next.Key, &value)

    /// Update state with a previous value. Should be optimized for incremental update of the current state in custom implementations.
    abstract TryUpdatePrevious: previous:KVP<'K,ValueTuple<'V1,'V2>> * [<Out>] value: byref<KVP<'K,'R>> -> bool
    override this.TryUpdatePrevious(previous:KVP<'K,ValueTuple<'V1,'V2>>, [<Out>] value: byref<KVP<'K,'R>>) : bool =
      // recreate value from scratch
      this.TryGetValue(previous.Key, &value)

    /// If input and this cursor support batches, then process a batch and store it in CurrentBatch
    abstract TryUpdateNextBatch: nextBatchL: IReadOnlyOrderedMap<'K,'V1> * nextBatchR: IReadOnlyOrderedMap<'K,'V2> * [<Out>] value: byref<IReadOnlyOrderedMap<'K,'R>> -> bool  
    override this.TryUpdateNextBatch(nextBatchL: IReadOnlyOrderedMap<'K,'V1>, nextBatchR: IReadOnlyOrderedMap<'K,'V2>, [<Out>] value: byref<IReadOnlyOrderedMap<'K,'R>>) : bool =
      // TODO need a quick check if batching gives great perf improvement, e.g. check if type is SortedMap and compare keys
      false

    member this.Reset() = 
      hasValidState <- false
      cursorL.Reset()
    member this.Dispose() = 
      hasValidState <- false
      cursorL.Dispose()

    interface IEnumerator<KVP<'K,'R>> with    
      member this.Reset() = this.Reset()
      member x.MoveNext(): bool =
        let cl = x.InputCursorL
        let cr = x.InputCursorR
        if hasValidState then // both cursors are aligned 
          let mutable found = false
          while not found && cr.MoveNext() do // NB! x.InputCursor.MoveNext() && not found // was stupid serious bug, order matters
            let ok, value = x.TryUpdateNext(x.InputCursorL.Current)
            if ok then 
              found <- true
              x.CurrentKey <- value.Key
              x.CurrentValue <- value.Value
          if found then 
            //hasInitializedValue <- true
            true
          else false
        else (x :> ICursor<'K,'R>).MoveFirst()
      member this.Current with get(): KVP<'K, 'R> = this.Current
      member this.Current with get(): obj = this.Current :> obj 
      member x.Dispose(): unit = x.Dispose()

    interface ICursor<'K,'R> with
      member x.Current: KVP<'K,'R> = KVP(x.CurrentKey, x.CurrentValue)
      member x.CurrentBatch: IReadOnlyOrderedMap<'K,'R> = x.CurrentBatch
      member x.CurrentKey: 'K = x.CurrentKey
      member x.CurrentValue: 'R = x.CurrentValue
      member x.IsContinuous: bool = x.IsContinuous
      member x.MoveAt(index: 'K, direction: Lookup): bool =
        let cl = x.InputCursorL
        let cr = x.InputCursorR
        if x.InputCursorL.MoveAt(index, direction) then
          let ok, value = x.TryGetValue(x.InputCursorL.CurrentKey)
          if ok then
            x.CurrentKey <- value.Key
            x.CurrentValue <- value.Value
            hasValidState <- true
            true
          else
            match direction with
            | Lookup.EQ -> false
            | Lookup.GE | Lookup.GT ->
              let mutable found = false
              while not found && x.InputCursorL.MoveNext() do
                let ok, value = x.TryGetValue(x.InputCursorL.CurrentKey)
                if ok then 
                  found <- true
                  x.CurrentKey <- value.Key
                  x.CurrentValue <- value.Value
              if found then 
                hasValidState <- true
                true 
              else false
            | Lookup.LE | Lookup.LT ->
              let mutable found = false
              while not found && x.InputCursorL.MovePrevious() do
                let ok, value = x.TryGetValue(x.InputCursorL.CurrentKey)
                if ok then
                  found <- true
                  x.CurrentKey <- value.Key
                  x.CurrentValue <- value.Value
              if found then 
                hasValidState <- true
                true 
              else false
            | _ -> failwith "wrong lookup value"
        else false
      
    
      member x.MoveFirst(): bool =
        let cl = x.InputCursorL
        let cr = x.InputCursorR

        if cl.MoveFirst() && cr.MoveFirst() then
          let c = cmp.Compare(cl.CurrentKey, cr.CurrentKey)

          let ok, value = x.TryGetValue(x.InputCursorL.CurrentKey)
          if ok then
            x.CurrentKey <- value.Key
            x.CurrentValue <- value.Value
            hasValidState <- true
            true
          else
            let mutable found = false
            while not found && x.InputCursorL.MoveNext() do
              let ok, value = x.TryGetValue(x.InputCursorL.CurrentKey)
              if ok then 
                found <- true
                x.CurrentKey <- value.Key
                x.CurrentValue <- value.Value
            if found then 
              hasValidState <- true
              true 
            else false
        else false
    
      member x.MoveLast(): bool = 
        let cl = x.InputCursorL
        let cr = x.InputCursorR
        if x.InputCursorL.MoveLast() then
          let ok, value = x.TryGetValue(x.InputCursorL.CurrentKey)
          if ok then
            x.CurrentKey <- value.Key
            x.CurrentValue <- value.Value
            hasValidState <- true
            true
          else
            let mutable found = false
            while not found && x.InputCursorL.MovePrevious() do
              let ok, value = x.TryGetValue(x.InputCursorL.CurrentKey)
              if ok then
                found <- true
                x.CurrentKey <- value.Key
                x.CurrentValue <- value.Value
            if found then 
              hasValidState <- true
              true 
            else false
        else false

      member x.MovePrevious(): bool = 
        let cl = x.InputCursorL
        let cr = x.InputCursorR
        if hasValidState then
          let mutable found = false
          while not found && x.InputCursorL.MovePrevious() do
            let ok, value = x.TryUpdatePrevious(x.InputCursorL.Current)
            if ok then 
              found <- true
              x.CurrentKey <- value.Key
              x.CurrentValue <- value.Value
          if found then 
            hasValidState <- true
            true 
          else false
        else (x :> ICursor<'K,'R>).MoveLast()
    
      member x.MoveNext(cancellationToken: Threading.CancellationToken): Task<bool> = 
        failwith "Not implemented yet"
      member x.MoveNextBatch(cancellationToken: Threading.CancellationToken): Task<bool> = 
        failwith "Not implemented yet"
    
      //member x.IsBatch with get() = x.IsBatch
      member x.Source: ISeries<'K,'R> = CursorSeries<'K,'R>((x :> ICursor<'K,'R>).Clone) :> ISeries<'K,'R>
      member x.TryGetValue(key: 'K, [<Out>] value: byref<'R>): bool = 
        let ok, v = x.TryGetValue(key)
        value <- v.Value
        ok
    
      // TODO review + profile. for value types we could just return this
      member x.Clone(): ICursor<'K,'R> =
        // run-time type of the instance, could be derived type
        let ty = x.GetType()
        let args = [|cursorFactoryL :> obj;cursorFactoryR :> obj|]
        // TODO using Activator is a very bad sign, are we doing something wrong here?
        let clone = Activator.CreateInstance(ty, args) :?> ICursor<'K,'R> // should not be called too often
        if hasValidState then clone.MoveAt(x.CurrentKey, Lookup.EQ) |> ignore
        //Debug.Assert(movedOk) // if current key is set then we could move to it
        clone