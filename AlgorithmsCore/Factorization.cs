using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore
{
    public static partial class Algorithms
    {
        public static Tuple<bool, List<PrimeNumber>> FactorizeBruteForce(BigInteger n)
        {
            var factors = new List<PrimeNumber> { new PrimeNumber(1, 1) };
            var isPrime = false;
            var initialValue = n;
            //This is possible source of headache
            var lastNum = BigInteger.Divide(n, 2);
            //Console.WriteLine(lastNum);
            //This is a costly step
            var primes = GetPrimeNumbersTillGiven(lastNum);
            foreach (var prime in primes)
            {
                PrimeNumber possibleFactor = new PrimeNumber(prime, 0);
                bool isFactor = false;
                while (BigInteger.GreatestCommonDivisor(n, prime) != 1)
                {
                    isFactor = true;
                    possibleFactor.IncrementPower();
                    n = BigInteger.Divide(n, prime);
                }
                if (isFactor)
                    factors.Add(possibleFactor);
            }
            if (factors.Count() == 1)
            {
                isPrime = true;
                factors.Add(new PrimeNumber(initialValue, 1));
            }
            return new Tuple<bool, List<PrimeNumber>>(isPrime, factors);
        }

        public static bool IsPrimeJakhongir(int n)
        {
            if (n <= 1)
                return false;
            if (n % 2 == 0 && n > 2)
                return false;
            for (var i = 3; i < Math.Sqrt(n) + 1; i += 2)
                if (n % i == 0)
                {
                    return false;
                }
            return true;
        }
        public static void PollardRho(BigInteger n)
        {
            var i = 1;
            var rand = new Random();
            BigInteger x_1 = rand.Next((int)n - 1);
            var y = x_1;
            var k = 2;
            BigInteger x_i = 0;
            while (i < 1000)
            {
                i++;
                if (x_i == 0)
                    x_i = x_1;
                else
                    x_i = (BigInteger.Pow(x_i, 2) - 1) % 2;
                var d = BigInteger.GreatestCommonDivisor(y - x_i, n);
                if (d != 0 && d != n)
                {

                    Console.WriteLine(d);
                }
                if (i == k)
                {
                    y = x_i;
                    k = 2 * k;
                }
            }
        }

        public static int GetNumberOfFactors(List<PrimeNumber> primeFactors)
        {
            var numberOfFactors = 1;
            if (primeFactors.Count == 1)
                return 1;
            for (var i = 1; i < primeFactors.Count; i++)
            {
                numberOfFactors *= (primeFactors[i].GetPower() + 1);
            }
            return numberOfFactors;
        }
    }

    public class PrimeNumber
    {
        private BigInteger _prime;
        private int _power;
        public PrimeNumber(BigInteger prime, int power)
        {
            _prime = prime;
            _power = power;
        }
        public void IncrementPower()
        {
            _power += 1;
        }

        public BigInteger GetNumber()
        {
            return _prime;
        }

        public int GetPower()
        {
            return _power;
        }
    }
}
