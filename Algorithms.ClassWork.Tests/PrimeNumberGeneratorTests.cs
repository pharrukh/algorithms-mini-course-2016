using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ClassWork.Tests
{
    [TestClass]
    public class PrimeNumberGeneratorTests
    {
        [TestMethod]
        public void PrimeGeneratorShouldReturnFirstTenNumbers()
        {
            //Assign | Arrange
            var expectedFirstTenPrimeNumbers = Fixtures.Fixtures.FirstTenPrimeNumbers();
            //Act
            var actualFirstTenPrimeNumbers = OurAlgorithms.GetPrimeNumbers(10);
            //Assert
            CollectionAssert.AreEqual(expectedFirstTenPrimeNumbers, actualFirstTenPrimeNumbers,
                "The two arrays are not equal");
        }

        [TestMethod]
        public void IsPrimeTest2()
        {
            //Act
            bool isPrimeResult = OurAlgorithms.IsPrime(2);
            //Assert
            Assert.AreEqual(true, isPrimeResult, "2 is shown as not prime");
        }

        [TestMethod]
        public void IsPrimeTest3()
        {
            //Act
            bool isPrimeResult = OurAlgorithms.IsPrime(3);
            //Assert
            Assert.AreEqual(true, isPrimeResult, "3 is shown as not prime");
        }

        [TestMethod]
        public void IsPrimeTest4()
        {
            //Act
            bool isPrimeResult = OurAlgorithms.IsPrime(4);
            //Assert
            Assert.AreEqual(false, isPrimeResult, "4 is shown as prime");
        }

        [TestMethod]
        public void IsPrime_OnFirstTenPrimes()
        {
            var primes = Fixtures.Fixtures.FirstTenPrimeNumbers();
            foreach (var prime in primes)
            {
                //Act
                bool isPrimeResult = OurAlgorithms.IsPrime(prime);
                //Assert
                Assert.AreEqual(true, isPrimeResult, prime + " is shown as non prime");
            }
        }
    }
}
