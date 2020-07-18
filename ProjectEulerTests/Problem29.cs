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
    public class Problem29
    {
        [TestMethod]
        public void MainTest()
        {
            var set = new HashSet<BigInteger>();
            for (var i = 2; i <= 100; i++)
                for (var j = 2; j <= 100; j++)
                {
                    set.Add(BigInteger.Pow(i, j));
                }
            Console.WriteLine("There are " + set.Count + " elements.");
            Assert.AreEqual(9183, set.Count);
        }
    }
}
