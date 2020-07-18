using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Threading;
using System.Timers;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    /// <summary>
    /// Summary description for PowerTests
    /// </summary>
    [TestClass]
    public class PowerTests
    {
        [TestMethod]
        public void PowerTest1()
        {
            Assert.AreEqual(4, AlgorithmsCore.Algorithms.Power(2, 2));
            Assert.AreEqual(1024, AlgorithmsCore.Algorithms.Power(2, 10));
            for (int i = 100; i < 120; i++)
            {
                var stopWatch1 = new Stopwatch();
                stopWatch1.Start();
                var genericAlgo = Pow(3234, i);
                stopWatch1.Stop();
                Console.WriteLine("Power: " + i);
                Console.WriteLine("C# algo time: " + stopWatch1.Elapsed);
                var stopWatch2 = new Stopwatch();
                stopWatch2.Start();
                var myAlgo = AlgorithmsCore.Algorithms.Power(3234, i);
                stopWatch2.Stop();
                Console.WriteLine("My algo time: " + stopWatch2.Elapsed);
                Console.WriteLine("----------------------------------");
                Assert.AreEqual(genericAlgo, myAlgo);
            }
        }

        private BigInteger Pow(BigInteger n, int p)
        {
            BigInteger result = n;
            for (int i = 1; i < p; i++)
            {
                result *= n;
            }
            return result;
        }
        
    }
}
