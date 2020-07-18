using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class FactorizationTests
    {
        [TestMethod]
        public void FactorizeBrudeForceTest20()
        {
            var factors = new List<PrimeNumber> { new PrimeNumber(1, 1), new PrimeNumber(2, 2), new PrimeNumber(5, 1) };
            var result = Algorithms.FactorizeBruteForce(20);
            Assert.AreEqual(false, result.Item1);
            Console.WriteLine(20+": "+PrintPowers(result.Item2));
            CollectionAssert.AreEqual(factors, result.Item2, new PrimeNumberEqualityComparer());
        }
        [TestMethod]
        public void FactorizeBrudeForceTest25()
        {
            var factors = new List<PrimeNumber> { new PrimeNumber(1, 1), new PrimeNumber(5, 2) };
            var result = Algorithms.FactorizeBruteForce(25);
            Assert.AreEqual(false, result.Item1);
            Console.WriteLine(25 + ": " + PrintPowers(result.Item2));
            CollectionAssert.AreEqual(factors, result.Item2, new PrimeNumberEqualityComparer());
        }
        [TestMethod]
        public void FactorizeBrudeForceTest13()
        {
            var factors = new List<PrimeNumber> { new PrimeNumber(1, 1), new PrimeNumber(13, 1) };
            var result = Algorithms.FactorizeBruteForce(13);
            Assert.AreEqual(true, result.Item1);
            Console.WriteLine(13 + ": " + PrintPowers(result.Item2));
            CollectionAssert.AreEqual(factors, result.Item2, new PrimeNumberEqualityComparer());
        }
        [TestMethod]
        public void FactorizeBrudeForceTest11()
        {
            var factors = new List<PrimeNumber> { new PrimeNumber(1, 1), new PrimeNumber(11, 1) };
            var result = Algorithms.FactorizeBruteForce(11);
            Assert.AreEqual(true, result.Item1);
            Console.WriteLine(11 + ": " + PrintPowers(result.Item2));
            CollectionAssert.AreEqual(factors, result.Item2, new PrimeNumberEqualityComparer());
        }
        [TestMethod]
        public void FactorizeBrudeForceTest625()
        {
            var factors = new List<PrimeNumber> { new PrimeNumber(1, 1), new PrimeNumber(5, 4) };
            var result = Algorithms.FactorizeBruteForce(625);
            Assert.AreEqual(false, result.Item1);
            Console.WriteLine(625 + ": " + PrintPowers(result.Item2));
            CollectionAssert.AreEqual(factors, result.Item2, new PrimeNumberEqualityComparer());
        }
        [TestMethod]
        public void FactorizeBrudeForceTest782747()
        {
            var factors = new List<PrimeNumber> { new PrimeNumber(1, 1), new PrimeNumber(7, 1) };
            var result = Algorithms.FactorizeBruteForce(782747);
            Assert.AreEqual(false, result.Item1);
            Console.WriteLine(PrintPowers(result.Item2));
            CollectionAssert.AreEqual(factors, result.Item2, new PrimeNumberEqualityComparer());
        }
        [TestMethod]
        public void RunTests()
        {
            for (int i = 10; i > 2; i--)
            {
                for (int j = 0; j < 5; j++)
                {
                    var randomNumber = Algorithms.GenerateRandomWithString(i);
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    var factors = Algorithms.FactorizeBruteForce(randomNumber);
                    stopWatch.Stop();
                    Console.WriteLine("Time: " + stopWatch.Elapsed);
                    Console.WriteLine(randomNumber + "=" + PrintPowers(factors.Item2));
                    Console.WriteLine("=======================");
                }
            }
        }

        //[TestMethod]
        //public void PollardRhoTests()
        //{
        //    Algorithms.PollardRho(625);
        //}
        private string PrintPowers(List<PrimeNumber> primes)
        {
            var result = new StringBuilder();
            foreach (var prime in primes)
            {
                result.Append(prime.GetNumber());
                result.Append('^');
                result.Append(prime.GetPower());
                if (prime != primes.Last())
                    result.Append('*');
            }
            return result.ToString();
        }

        [TestMethod]
        public void IsPrimeJakhongirTest()
        {
            Assert.IsFalse(Algorithms.IsPrimeJakhongir(15));
            Assert.IsFalse(Algorithms.IsPrimeJakhongir(225));
        }
    }

    public class PrimeNumberEqualityComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ComparePrimeNumber((PrimeNumber)x, (PrimeNumber)y);
        }
        private int ComparePrimeNumber(PrimeNumber x, PrimeNumber y)
        {
            if (x.GetNumber() == y.GetNumber() && x.GetPower() == y.GetPower())
                return 0;
            return 1;
        }
    }

}
