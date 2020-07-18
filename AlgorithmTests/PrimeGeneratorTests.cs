using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class PrimeGeneratorTests
    {
        [TestMethod]
        public void PrimeGeneratorTest()
        {
            for (int i = 20; i <= 100; i = i + 20)
            {
                var p = Algorithms.GetBigPrime(i);
                Console.WriteLine(p);
            }
        }
        [TestMethod]
        public void GenerateNumberTest()
        {
            for (int i = 20; i < 1000; i = i + 20)
            {
                var p = Algorithms.GenerateRandomWithString(i);
                Assert.AreEqual(i, p.ToString().Length);
                Console.WriteLine(p);
            }
        }

        [TestMethod]
        public void IsPrimeTest()
        {
            var p1 = BigInteger.Parse("12131072439211271897323671531612440428472427633701410925634549312301964373042085619324197365322416866541017057361365214171711713797974299334871062829803541");
            var p2 = BigInteger.Parse("12027524255478748885956220793734512128733387803682075433653899983955179850988797899869146900809131611153346817050832096022160146366346391812470987105415233");
            var p3 = BigInteger.Parse("65537");

            foreach (var n in new List<BigInteger> { p1, p2, p3 })
                Assert.IsTrue(Algorithms.IsPrime(n, n.ToString().Length), "The number " + n + " is not prime.");
        }
    }
}
