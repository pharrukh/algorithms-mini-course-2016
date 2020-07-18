using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.ClassWork
{
    public static partial class OurAlgorithms
    {
        /// <summary>
        /// Returns prime numbers
        /// </summary>
        /// <param name="n">The ammount of prims numbers</param>
        /// <returns>Array of integers</returns>
        public static int[] GetPrimeNumbers(int n)
        {
            throw new NotImplementedException();
        }

        public static bool IsPrime(int n)
        {
            if (n < 2)
                throw new ArgumentException("Numbers should be more than 2");
            if (n == 2)
                return true;
            for (var i = 2; i <= n / 2 + 1; i++)
                if (n % i == 0) return false;
            return true;

        }
    }
}
