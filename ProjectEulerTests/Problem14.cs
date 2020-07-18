using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    /// <summary>
    /// The following iterative sequence is defined for the set of positive integers:
    ///n → n/2 (n is even)
    ///n → 3n + 1 (n is odd)
    ///Using the rule above and starting with 13, we generate the following sequence:
    ///13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    ///It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
    ///Which starting number, under one million, produces the longest chain?
    ///NOTE: Once the chain starts the terms are allowed to go above one million.
    /// </summary>
    [TestClass]
    public class Problem14
    {
        [TestMethod]
        public void PrintQuantity()
        {
            var result = new List<Tuple<BigInteger, int>>();
            for (int i = 1000000; i >= 1; i--)
            {
                var chain = new List<BigInteger>();
                chain = ProduceChainRecursive(i, chain);
                result.Add(new Tuple<BigInteger, int>(i, chain.Count));
                //Console.WriteLine(i + " | " + chain.Count);
            }
            var maxChainLength = result.Max(x => x.Item2);
            var resultingTuple = result.Where(t => t.Item2 == maxChainLength).First();
            Assert.AreEqual(837799, resultingTuple.Item1);
        }
        [TestMethod]
        public void Problem14Test()
        {
            for (int i = 90; i >= 1; i--)
            {
                Console.WriteLine("====================");
                var chain = new List<BigInteger>();
                chain = ProduceChainRecursive(i, chain);
                Console.WriteLine("Number : " + i);
                PrintSequence(chain);
                Console.WriteLine("====================");
            }
        }
        [TestMethod]
        public void ProduceChainTest()
        {
            var chain = new List<BigInteger>();
            chain = ProduceChainRecursive(13, chain);
            var expectedList = new List<BigInteger> { 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 };
            CollectionAssert.AreEqual(expectedList, chain);
        }
        public List<BigInteger> ProduceChainRecursive(BigInteger startingNumber, List<BigInteger> chain)
        {
            chain.Add(startingNumber);
            if (startingNumber == 1)
                return chain;
            if (startingNumber % 2 == 0)
                return ProduceChainRecursive(startingNumber / 2, chain);
            return ProduceChainRecursive(3 * startingNumber + 1, chain);
        }
        private void PrintSequence(List<BigInteger> chain)
        {
            foreach (var num in chain)
            {
                Console.Write(num);
                if (num != chain.Last())
                    Console.Write("->");
            }
            Console.WriteLine();
        }
    }
}
