using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class GenerateTriangleNumbersTests
    {
        [TestMethod]
        public void GerenateConrrectly()
        {
            CollectionAssert.AreEqual(new List<BigInteger>() { 1, 3, 6 }, Algorithms.GenerateTriangleNumbers(3));
            CollectionAssert.AreEqual(new List<BigInteger>() { 1, 3, 6, 10 }, Algorithms.GenerateTriangleNumbers(4));
            CollectionAssert.AreEqual(new List<BigInteger>() { 1, 3, 6, 10, 15 }, Algorithms.GenerateTriangleNumbers(5));
            CollectionAssert.AreEqual(new List<BigInteger>() { 1, 3, 6, 10, 15, 21, 28 }, Algorithms.GenerateTriangleNumbers(7));
           
        }
    }
}
