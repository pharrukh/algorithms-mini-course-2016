using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    [TestClass]
    public class Problem12
    {
        [TestMethod]
        public void SimpleFactorsTest1()
        {
            var primeFactors = AlgorithmsCore.Algorithms.FactorizeBruteForce(3);
            Assert.AreEqual(2, AlgorithmsCore.Algorithms.GetNumberOfFactors(primeFactors.Item2));
        }
        [TestMethod]
        public void SimpleFactorsTest2()
        {
            var primeFactors = AlgorithmsCore.Algorithms.FactorizeBruteForce(6);
            Assert.AreEqual(4, AlgorithmsCore.Algorithms.GetNumberOfFactors(primeFactors.Item2));
        }
        [TestMethod]
        public void SimpleFactorsTest3()
        {
            var primeFactors = AlgorithmsCore.Algorithms.FactorizeBruteForce(10);
            Assert.AreEqual(4, AlgorithmsCore.Algorithms.GetNumberOfFactors(primeFactors.Item2));
        }
        [TestMethod]
        public void SimpleFactorsTest4()
        {
            var primeFactors = AlgorithmsCore.Algorithms.FactorizeBruteForce(28);
            Assert.AreEqual(6, AlgorithmsCore.Algorithms.GetNumberOfFactors(primeFactors.Item2));
        }

        [TestMethod]
        public void SimpleFactorsTestMain()
        {
           
        }
    }
}
