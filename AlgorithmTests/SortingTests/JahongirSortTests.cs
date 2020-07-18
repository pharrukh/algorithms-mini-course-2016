using System;
using AlgorithmsCore.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.SortingTests
{
    [TestClass]
    public class JahongirSortTests
    {
        [TestMethod]
        public void MainTest()
        {
            var a = new IComparable[] { 10, 8, 6 };
            var sorted = new IComparable[] { 6, 8, 10 };
            var mSort = new JahongirSort();
            mSort.Sort(a);
            CollectionAssert.AreEqual(sorted, a);
        }
    }
}
