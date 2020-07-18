using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    [TestClass]
    public class Problem26
    {
        [TestMethod]
        public void MainTest()
        {
            for (var i = 1000; i >= 1; i--)
            {
                Console.WriteLine(Math.Pow(10, 100) / (double)i);
            }
        }
    }
}
