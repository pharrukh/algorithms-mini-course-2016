using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.ExceptionServices;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmTests
{
    [TestClass]
    public class EuclidianAlgorithmTests
    {
        [TestMethod]
        public void EuclidianAlgorithm()
        {
            Assert.AreEqual(15, Algorithms.EuclidianAlgorithm(45, 60));
            Assert.AreEqual(3, Algorithms.EuclidianAlgorithm(3999, 10023));
            Assert.AreEqual(1, Algorithms.EuclidianAlgorithm(2342346, 23423561));
            Assert.AreEqual(1, Algorithms.EuclidianAlgorithm(3746382641, 9048472518));
            Assert.AreEqual(3, Algorithms.EuclidianAlgorithm(81, 21));
        }
    }
}
