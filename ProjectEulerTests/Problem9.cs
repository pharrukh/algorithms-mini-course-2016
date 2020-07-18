using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    [TestClass]
    public class Problem9
    {
        [TestMethod]
        public void Problem9Test()
        {
            var triplet = GenerateTripletStochastic();
            Assert.IsTrue(triplet.Contains(200));
            Assert.IsTrue(triplet.Contains(375));
            Assert.IsTrue(triplet.Contains(425));
            Assert.AreEqual(31875000, triplet[0] * triplet[1] * triplet[2]);
        }
        [TestMethod]
        public void Problem9StopWatchTest()
        {
            var result = FunctionsRunner();
            Console.WriteLine("Stochastic method average time: " + result[0]);
            Console.WriteLine("Determinant method average time: " + result[1]);
        }

        private string[] FunctionsRunner()
        {
            var stopWatch = new Stopwatch();
            var stochTime = new List<long>();
            var determTime = new List<long>();
            for (var i = 0; i < 100; i++)
            {
                stopWatch.Start();
                GenerateTripletStochastic();
                stopWatch.Stop();
                stochTime.Add(stopWatch.ElapsedMilliseconds);
                stopWatch.Reset();
                stopWatch.Start();
                GenerateTriplet();
                stopWatch.Stop();
                determTime.Add(stopWatch.ElapsedMilliseconds);
                stopWatch.Reset();
            }
            return new string[] { stochTime.Average().ToString(), determTime.Average().ToString() };
        }
        private static int[] GenerateTriplet()
        {
            int a, b, c;
            for (a = 1; a < 998; a++)
            {
                for (b = 1; b < 998; b++)
                {
                    c = 1000 - (a + b);
                    if (c > 0 && (((a * a) + (b * b) == (c * c)) || ((c * c) + (b * b) == (a * a)) || ((a * a) + (c * c) == (b * b))))
                        return new int[] { a, b, c };
                }
            }
            throw new Exception("Failed to find");
        }
        private static int[] GenerateTripletStochastic()
        {
            int a, b, c;
            var random = new Random();
            while (true)
            {
                a = random.Next(1, 998);
                b = random.Next(1, 998);
                c = 1000 - a - b;
                if (c > 0 && (((a * a) + (b * b) == (c * c)) || ((c * c) + (b * b) == (a * a)) || ((a * a) + (c * c) == (b * b))))
                    return new int[] { a, b, c };
            }
        }
    }
}
