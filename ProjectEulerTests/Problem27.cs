using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    [TestClass]
    public class Problem27
    {
        [TestMethod]
        public void MainClass()
        {
            var p = new Polyndrom();
            var result = p.RunTests();
            var solution = result[p.indexOfMax];
            var product = solution[0] * solution[1];
            Console.WriteLine("a: " + solution[0] + " | " + "b: " + solution[1]);
            Console.WriteLine("The number of primes is: " + solution[2]);
            Console.WriteLine("The answer is: " + product);
            Assert.AreEqual(-59231, product);
        }
    }

    public class Polyndrom
    {
        private int[] As;
        private int[] Bs;
        private int[][] Results = new int[1999 * 1999][];
        private BigInteger[] SimplePrimes = Algorithms.GetPrimeNumbers(1000);
        public int indexOfMax = 0;
        public BigInteger curMax = 0;
        public Polyndrom()
        {
            As = new int[1999];
            Bs = new int[1999];
            var numToAdd = -999;
            for (var i = 0; i < 1999; i++)
            {
                As[i] = numToAdd;
                Bs[i] = numToAdd;
                numToAdd++;
            }
        }

        public int[][] RunTests()
        {
            var i = 0;
            foreach (var a in As)
            {
                foreach (var b in Bs)
                {
                    var testResult = new int[3];
                    testResult[0] = a;
                    testResult[1] = b;
                    testResult[2] = TrySimpleTest(a, b);
                    if (testResult[2] > curMax)
                    {
                        curMax = testResult[2];
                        indexOfMax = i;
                    }
                    Results[i] = testResult;
                    i++;
                }
            }
            return Results;
        }

        private int TrySimpleTest(int a, int b)
        {
            var n = 0;
            var numOfPrimes = 0;
            while (true)
            {
                var posPrime = n * n + a * n + b;
                if (posPrime <= 0)
                    return numOfPrimes;
                var numOfDigits = Algorithms.GetNumberOfDigits(posPrime);
                if (numOfDigits < 4)
                {
                    if (!SimplePrimes.Contains(posPrime))
                        return numOfPrimes;
                    numOfPrimes++;
                }
                else
                {
                    if (!Algorithms.IsPrime(posPrime, numOfDigits))
                        return numOfPrimes;
                    numOfPrimes++;
                }
                n++;
            }
        }
    }
}
