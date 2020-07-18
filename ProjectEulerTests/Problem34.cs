using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    [TestClass]
    public class Problem34
    {
        [TestMethod]
        public void MainTest()
        {
            var sum = 0;
            for (var i = 3; i <= 1000 * 1000; i++)
            {
                if (IsDigitFactorial(i))
                    sum += i;
            }
            Assert.AreEqual(40730, sum);
        }

        private bool IsDigitFactorial(int n)
        {
            var sum = 0;
            foreach (var digit in n.ToString().ToCharArray())
            {
                var num = int.Parse(digit.ToString());
                var fact = 1;
                for (var i = 1; i <= num; i++)
                    fact *= i;
                sum += fact;
            }
            if (n == sum)
                return true;
            return false;
        }
    }
}
