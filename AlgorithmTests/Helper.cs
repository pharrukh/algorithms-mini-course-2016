using System;
using System.Diagnostics;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class Helper
    {
        [TestMethod]
        public void HelperTest()
        {
            var stopWatch = new Stopwatch();
            //for (var i = 0; i < 1000; i++)
            //{
            stopWatch.Start();
            Algorithms.GenerateTriangleNumbers(10000000);
            stopWatch.Stop();
            Console.WriteLine("I used this time: " + stopWatch.Elapsed);
            //}
        }
    }
}
