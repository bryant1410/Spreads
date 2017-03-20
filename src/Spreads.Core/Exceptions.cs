﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;

namespace Spreads
{
    /// <summary>
    /// Exceptions related to data integrity and other Spreads-specific logic
    /// </summary>
    public class SpreadsException : Exception
    {
        public SpreadsException()
        {
        }

        public SpreadsException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// This exception is thrown during a cursor movements when new data could affect cursor values:
    /// e.g. data was updated at a key before the current cursor position and the cursor is moving forward
    /// or the cursor depends on the past.
    /// It is easy to recover from this exception using the cursor MoveAt method and CurrentKey/NewKey properties
    /// of this exception. E.g. MoveAt(ex.CurrentKey, Lookup.GT) in a catch block is equivalent to ignoring
    /// the exception and continuing to MoveNext.
    /// To replay values that could have been altered by an out-of-order data point, one could use MoveAt(ex.NewKey, Lookup.EQ).
    /// It is the responsibility of cursor consumer to recover from this exception, cursors should not implement any "smart"
    /// behavior unless it is a part of cursor definition and is explicitly documented.
    /// The state of cursor is undefined and invalid after the exception is thrown.
    /// </summary>
    public class OutOfOrderKeyException<K> : SpreadsException
    {
        /// <summary>
        /// Key/value before arrival of out-of-order data point
        /// </summary>
        public K CurrentKey { get; }

        /// <summary>
        /// Key/value of an out-of-order data point
        /// </summary>
        public K NewKey { get; }

        public bool HasKnownNewKey { get; }

        public OutOfOrderKeyException(K currentKey, K newKey, string message = "Out of order data") : base(message)
        {
            CurrentKey = currentKey;
            NewKey = newKey;
            HasKnownNewKey = true;
        }

        public OutOfOrderKeyException(K currentKey, string message = "Out of order data") : base(message)
        {
            CurrentKey = currentKey;
            HasKnownNewKey = false;
        }
    }
}