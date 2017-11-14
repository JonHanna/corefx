// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace System
{
    // A PRNG implementing Sebastiano Vigna's xorshift128+
    // http://vigna.di.unimi.it/ftp/papers/xorshiftplus.pdf
    // to produce integers within a non-negative range.
    // More than twice as fast as Random's Next(int, int).
    internal struct XorShift128PlusRandom
    {
        private ulong _s0;
        private ulong _s1;

        public static XorShift128PlusRandom Create()
        {
            ulong tickCount = (ulong)Environment.TickCount;
            return new XorShift128PlusRandom
            {
                _s0 = tickCount * 0X100000001UL,
                _s1 = tickCount * 0XFFFFFFFFUL
            };
        }

        public int Next(int min, int max)
        {
            // If adapting to allow min to be negative, the case of (max - min) > int.MaxValue
            // will need to be handled differently.
            Debug.Assert(min >= 0);
            Debug.Assert(max >= min);
            ulong x = _s0;
            ulong y = _s1;
            _s0 = y;
            x ^= x << 23;
            ulong next = (_s1 = x ^ y ^ (x >> 17) ^ (x >> 26)) + y;
            return min + (int)((next & long.MaxValue) / (double)long.MaxValue * (max - min));
        }
    }
}
