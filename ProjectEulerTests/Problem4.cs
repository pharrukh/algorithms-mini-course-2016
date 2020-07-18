using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    [TestClass]
    public class Problem4
    {
        [TestMethod]
        public void Problem4Test()
        {
            var polindroms = GeneratePolindroms();
            var max = polindroms.Max();
            Assert.AreEqual(906609, max);
        }
        private static List<int> GeneratePolindroms()
        {
            List<int> polindroms = new List<int>();
            for (var i = 100; i <= 999; i++)
            {
                for (var j = 100; j <= 999; j++)
                {
                    var possiblePolindrom = i * j;
                    var numAsString = possiblePolindrom.ToString();
                    var reversedNum = StringHelpers.Reverse(numAsString);
                    if (string.Equals(numAsString, reversedNum))
                        polindroms.Add(possiblePolindrom);
                }
            }
            return polindroms;
        }

    }
}
