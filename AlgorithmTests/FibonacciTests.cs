using System;
using System.Collections.Generic;
using System.Numerics;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FirstFib()
        {
            var fibMatrix = new FibMatix();
            Assert.AreEqual(1, fibMatrix.GetFibNum(1));
        }
        [TestMethod]
        public void SecondFib()
        {
            var fibMatrix = new FibMatix();
            Assert.AreEqual(1, fibMatrix.GetFibNum(2));
        }
        [TestMethod]
        public void ThirdFib()
        {
            var fibMatrix = new FibMatix();
            Assert.AreEqual(2, fibMatrix.GetFibNum(3));
        }
        [TestMethod]
        public void FourthFib()
        {
            var fibMatrix = new FibMatix();
            Assert.AreEqual(3, fibMatrix.GetFibNum(4));
        }
        [TestMethod]
        public void FirstTenFib()
        {
            var fibMatrix = new FibMatix();
            Assert.AreEqual(3, fibMatrix.GetFibNum(4));
            Assert.AreEqual(5, fibMatrix.GetFibNum(5));
            Assert.AreEqual(8, fibMatrix.GetFibNum(6));
            Assert.AreEqual(13, fibMatrix.GetFibNum(7));
            Assert.AreEqual(21, fibMatrix.GetFibNum(8));
            Assert.AreEqual(34, fibMatrix.GetFibNum(9));
        }
        [TestMethod]
        public void BulkTest()
        {
            var fibSeq = new List<BigInteger> { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            var fibMatrix = new FibMatix();
            var actualFibSeq = fibMatrix.GenerateFibNum(9);
            CollectionAssert.AreEqual(fibSeq, actualFibSeq);
        }
        [TestMethod]
        public void Viewer()
        {
            var fibMatrix = new FibMatix();
            var actualFibSeq = fibMatrix.GenerateFibNum(5000);
            actualFibSeq.Reverse();
            foreach (var bigInteger in actualFibSeq)
            {
                Console.WriteLine("Number of digs: "+Algorithms.GetNumberOfDigits(bigInteger));
            }
        }
    }
}
