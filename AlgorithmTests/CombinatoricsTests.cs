using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class CombinatoricsTests
    {
        [TestMethod]
        public void PermitationsSimpleTest()
        {
            var P = new char[] { 'a' };
            Algorithms.GetPer(P);
            CollectionAssert.AreEqual(new char[] { 'a' }, P);
        }
        [TestMethod]
        public void PermitationsTwoLetters()
        {
            var P = new char[] { 'a','b' };
            Algorithms.GetPer(P);
            CollectionAssert.AreEqual(new char[] { 'a' }, P);
        }
    }
}
