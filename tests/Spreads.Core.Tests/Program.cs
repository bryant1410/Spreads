﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.


using System;

namespace Spreads.Core.Tests {
    class Program {
        static void Main(string[] args)
        {
            (new ObjectPoolsTests()).ComparePoolsPerformance();
            Console.ReadLine();
        }
    }
}
