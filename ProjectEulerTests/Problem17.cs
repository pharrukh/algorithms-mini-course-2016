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
    public class Problem17
    {
        [TestMethod]
        public void Test()
        {
            var allNumbers = "";
            for (var i = 1; i <= 1000; i++)
                allNumbers += StringHelpers.SpellNumber(i);
            Assert.AreEqual(21124, CountLetters(allNumbers));
        }
        [TestMethod]
        public void TestSample()
        {
            var num_342 = StringHelpers.SpellNumber(342);
            var num_115 = StringHelpers.SpellNumber(115);
            Assert.AreEqual(23, CountLetters(num_342));
            Assert.AreEqual(20, CountLetters(num_115));
        }
        private int CountLetters(string spelledNumber)
        {
            string parsedString = String.Join("", spelledNumber.Split('-', ' '));
            return parsedString.Length;
        }
    }
}
