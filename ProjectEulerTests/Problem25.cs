using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    [TestClass]
    public class Problem25
    {
        [TestMethod]
        public void MainTest()
        {
            var extMatrix = new ExtendedFibMatrix();
            var richSeq = extMatrix.GetRichFibSequence(5000);
            var fibNumsWithThousandDigits = richSeq.Where(l => l[2] == 1000).Min(x => x[0]);
            Assert.AreEqual(4782, fibNumsWithThousandDigits);
        }
        [TestMethod]
        public void ExtendedMatrixTest1()
        {
            var extMatrix = new ExtendedFibMatrix();
            var richSeq = extMatrix.GetRichFibSequence(10);
            CollectionAssert.AreEqual(new BigInteger[] { 1, 1, 1 }, richSeq[0]);
            CollectionAssert.AreEqual(new BigInteger[] { 2, 1, 1 }, richSeq[1]);
            CollectionAssert.AreEqual(new BigInteger[] { 3, 2, 1 }, richSeq[2]);
            CollectionAssert.AreEqual(new BigInteger[] { 4, 3, 1 }, richSeq[3]);
            CollectionAssert.AreEqual(new BigInteger[] { 5, 5, 1 }, richSeq[4]);
            CollectionAssert.AreEqual(new BigInteger[] { 6, 8, 1 }, richSeq[5]);
            CollectionAssert.AreEqual(new BigInteger[] { 7, 13, 2 }, richSeq[6]);
        }
    }

    public class ExtendedFibMatrix : FibMatix
    {
        public BigInteger[][] GetRichFibSequence(int n)
        {
            BigInteger[][] richFibSequence = new BigInteger[n][];
            for (var i = 1; i <= n; i++)
            {
                var fibNum = this.GetFibNum(i);
                var index = this.CurrentIndex();
                var numLength = Algorithms.GetNumberOfDigits(fibNum);
                richFibSequence[i - 1] = new BigInteger[] { index, fibNum, numLength };
            }
            return richFibSequence;
        }
    }
}
