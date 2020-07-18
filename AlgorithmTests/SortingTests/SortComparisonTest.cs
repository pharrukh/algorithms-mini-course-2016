using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using AlgorithmsCore.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.SortingTests
{
    [TestClass]
    public class SortComparisonTest
    {
        [TestMethod]
        public void BestCaseComparison()
        {
            var stopWatch = new Stopwatch();
            var collection = GetBestCaseArray(10000);
            var a1 = (IComparable[])collection.Clone();
            var a2 = (IComparable[])collection.Clone();
            var mSort = new MaksimSort();
            var jSort = new JahongirSort();

            stopWatch.Start();
            mSort.Sort(a1);
            stopWatch.Stop();
            var mTime = stopWatch.ElapsedTicks;

            stopWatch.Reset();

            stopWatch.Start();
            jSort.Sort(a1);
            stopWatch.Stop();
            var jTime = stopWatch.ElapsedTicks;

            Console.WriteLine($"# 10000: Jahongir time {jTime}, Maksim time {mTime}");
            Console.WriteLine($"Maskim's algo is {jTime / mTime} times faster");
        }
        [TestMethod]
        public void WorstCaseComparison()
        {
            var stopWatch = new Stopwatch();
            var collection = GetWorstCaseArray(20000);
            var a1 = (IComparable[])collection.Clone();
            var a2 = (IComparable[])collection.Clone();
            var mSort = new MaksimSort();
            var jSort = new JahongirSort();

            stopWatch.Start();
            mSort.Sort(a1);
            stopWatch.Stop();
            var mTime = stopWatch.ElapsedMilliseconds;

            stopWatch.Reset();

            stopWatch.Start();
            jSort.Sort(a1);
            stopWatch.Stop();
            var jTime = stopWatch.ElapsedMilliseconds;

            Console.WriteLine($"# 90000: Jahongir time {jTime}, Maksim time {mTime}");
            Console.WriteLine($"Maskim's algo is {mTime / jTime} times faster");
        }

        private IComparable[] GetBestCaseArray(int n)
        {
            IComparable[] arr = new IComparable[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
            return arr;
        }
        private IComparable[] GetWorstCaseArray(int n)
        {
            IComparable[] arr = new IComparable[n];
            for (int i = n; i > 0; i--)
            {
                arr[n - i] = i;
            }
            return arr;
        }
    }
}
