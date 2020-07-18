using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    [TestClass]
    public class Problem30
    {
        [TestMethod]
        public void MainTest()
        {
            List<int> result = new List<int>();
            for (var i = 2; i <= 999999; i++)
            {
                if (CheckDigitSum(i))
                    result.Add(i);
            }
            Console.WriteLine("I found " + result.Count + " numbers");
            Console.WriteLine("Their sum is " + result.Sum());
            Assert.AreEqual(443839, result.Sum());
        }

        private bool CheckDigitSum(int n)
        {
            var sum = GetFifthPowerSum(n);
            if (sum == n)
                return true;
            return false;
        }

        private int GetFifthPowerSum(int n)
        {
            var sum = 0;
            foreach (var digit in n.ToString().ToCharArray())
            {
                var num = int.Parse(digit.ToString());
                sum += (int)Math.Pow(num, 5);
            }
            return sum;
        }
    }
}
