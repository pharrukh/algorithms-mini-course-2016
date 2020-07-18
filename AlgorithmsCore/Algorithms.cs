using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore
{
    public static partial class Algorithms
    {
        /// <summary>
        /// Returns first n prime numbers
        /// </summary>
        /// <param name="n">The last nth prime BigIntegerex</param>
        /// <returns></returns>
        public static BigInteger[] GetPrimeNumbers(BigInteger n)
        {
            var list = new List<BigInteger>();
            list.AddRange(new List<BigInteger>() { 2, 3, 5, 7, 11 });
            var possiblePrime = list.Last();
            var i = 0;
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            do
            {
                possiblePrime += 2;
                bool isDivisible = false;
                foreach (var prime in list)
                {
                    //Console.WriteLine("prime: " + prime);
                    //Console.WriteLine("possible prime: " + possiblePrime);
                    if (possiblePrime % prime == 0)
                    {
                        isDivisible = true;
                        break;
                    }
                }
                if (isDivisible == false)
                {
                    list.Add(possiblePrime);
                    i++;
                }

            } while (i < n - 1);
            //Console.WriteLine("Number of primes found: " + list.Count());

            //stopwatch.Stop();
            //var milliSeocnds = stopwatch.ElapsedMilliseconds;

            // Console.WriteLine(possiblePrime + " | " + milliSeocnds + " milliseconds.");

            //System.Console.ReadKey();
            return list.ToArray();
        }

        /// <summary>
        /// Returns first n prime numbers
        /// </summary>
        /// <param name="n">The last nth prime BigIntegerex</param>
        /// <returns></returns>
        public static BigInteger[] GetPrimeNumbersTillGiven(BigInteger n)
        {
            var list = new List<BigInteger>();
            list.AddRange(new List<BigInteger>() { 2, 3 });
            var possiblePrime = list.Last();
            var i = 0;
            while (possiblePrime < n)
            {
                possiblePrime += 2;
                bool isDivisible = false;
                foreach (var prime in list.GetRange(0, list.Count / 2))
                {
                    if (possiblePrime % prime == 0)
                    {
                        isDivisible = true;
                        break;
                    }
                }
                if (isDivisible == false)
                {
                    list.Add(possiblePrime);
                    i++;
                }
            }
            return list.ToArray();
        }
        //public static long[] GetPrimeNumbersTillGiven(long n)
        //{
        //    var list = new List<long>();
        //    list.AddRange(new List<long>() { 2, 3 });
        //    var possiblePrime = list.Last();
        //    var i = 0;
        //    while (possiblePrime < n)
        //    {
        //        possiblePrime += 2;
        //        bool isDivisible = false;
        //        foreach (var prime in list)
        //        {
        //            if (possiblePrime % prime == 0)
        //            {
        //                isDivisible = true;
        //                break;
        //            }
        //        }
        //        if (isDivisible == false)
        //        {
        //            list.Add(possiblePrime);
        //            i++;
        //        }
        //    }
        //    return list.ToArray();
        //}
        public static BigInteger[] EfficientGetPrimeNumbersTillGiven(BigInteger n)
        {
            var list = new List<BigInteger>();
            list.AddRange(new List<BigInteger>() { 2, 3 });
            var possiblePrime = list.Last();
            var i = 0;
            do
            {
                possiblePrime += 2;
                bool isDivisible = false;
                if (possiblePrime < 1000)
                {
                    foreach (var prime in list)
                    {
                        if (possiblePrime % prime == 0)
                        {
                            isDivisible = true;
                            break;
                        }
                    }
                }
                else
                {
                    if (!IsPrime(possiblePrime, possiblePrime.ToString().Length))
                        isDivisible = true;
                }
                if (isDivisible == false)
                {
                    if (possiblePrime < n)
                        list.Add(possiblePrime);
                    i++;
                }
            } while (possiblePrime < n);
            return list.ToArray();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Number of elements to generate</param>
        /// <returns></returns>
        public static List<BigInteger> GenerateTriangleNumbers(BigInteger n)
        {
            var triangleNumbers = new List<BigInteger>();
            var i = 1;
            var numberToAdd = 0;
            while (true)
            {
                numberToAdd += i;
                triangleNumbers.Add(numberToAdd);
                if (triangleNumbers.Count == n)
                    return triangleNumbers;
                i++;
            }
        }
    }
}
