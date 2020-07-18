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
    public class Problem20
    {
        [TestMethod]
        public void MainTest()
        {
            BigInteger a = 1;
            for (var i = 2; i <= 100; i++)
                a = BigInteger.Multiply(a, i);
            Assert.AreEqual(648, NumberHelpers.GetSumOfDigits(a.ToString()));
        }
    }
}
