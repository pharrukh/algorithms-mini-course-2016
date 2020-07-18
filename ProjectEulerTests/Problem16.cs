using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    /// <summary>
    /// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
    ///What is the sum of the digits of the number 2^1000?
    /// </summary>
    [TestClass]

    public class Problem16
    {
        [TestMethod]
        public void SumOfDigits()
        {
            var number = BigInteger.Pow(2, 1000).ToString();
            var sum = NumberHelpers.GetSumOfDigits(number);
            Assert.AreEqual(1366, sum);
        }
        [TestMethod]
        public void GetSumOfDigitsTest1()
        {
            var number = "1000";
            var sum = NumberHelpers.GetSumOfDigits(number);
            Assert.AreEqual(1, sum);
        }
        [TestMethod]
        public void GetSumOfDigitsTest2()
        {
            var number = "1234";
            var sum = NumberHelpers.GetSumOfDigits(number);
            Assert.AreEqual(10, sum);
        }

    }
}
