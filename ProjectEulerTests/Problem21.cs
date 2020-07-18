using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    [TestClass]
    public class Problem21
    {
        [TestMethod]
        public void AmicableTestMain()
        {
            var amicableNumbers = new List<int>();
            for (var i = 1; i < 10000; i++)
            {
                if (IsAmicable(i))
                    amicableNumbers.Add(i);
            }
            Assert.AreEqual(31626, amicableNumbers.Sum());
        }
        [TestMethod]
        public void GetProperDivisorsTest220()
        {
            var expectedDivisors = new List<int> { 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110 };
            var actualDivisors = GetProperDivisors(220);
            CollectionAssert.AreEqual(expectedDivisors, actualDivisors);
        }
        [TestMethod]
        public void AmicabilityTestSample()
        {
            Assert.IsTrue(IsAmicable(220));
            Assert.IsTrue(IsAmicable(284));
        }
        [TestMethod]
        public void GetProperDivisorsTest284()
        {
            var expectedDivisors = new List<int> { 1, 2, 4, 71, 142 };
            var actualDivisors = GetProperDivisors(284);
            CollectionAssert.AreEqual(expectedDivisors, actualDivisors);
        }
        public List<int> GetProperDivisors(int n)
        {
            var properDivisors = new List<int>();
            for (var i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    properDivisors.Add(i);
            }
            return properDivisors;
        }

        public bool IsAmicable(int a)
        {
            var a_properDivisors = GetProperDivisors(a);
            var a_sum = GetSumOfDivisors(a_properDivisors);
            var b = a_sum;
            var b_properDivisors = GetProperDivisors(b);
            var b_sum = GetSumOfDivisors(b_properDivisors);
            if (a == b_sum && a != b)
                return true;
            return false;
        }

        public int GetSumOfDivisors(List<int> divisors)
        {
            return divisors.Sum();
        }
    }
}
