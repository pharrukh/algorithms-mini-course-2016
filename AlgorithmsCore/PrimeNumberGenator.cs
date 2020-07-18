using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore
{
    public partial class Algorithms
    {
        private static readonly Random rand = new Random();
        private static readonly char[] Digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static readonly char[] PrimeEndings = { '1', '3', '7', '9' };
        public static BigInteger GetBigPrime(int length)
        {
            BigInteger p;
            do
            {
                p = GenerateRandomWithString(length);
            } while (!IsPrime(p, length));
            return p;
        }

        public static BigInteger GenerateRandomWithString(int length)
        {
            var p = new StringBuilder(length);
            for (int i = 1; i < length; i++)
            {
                if (i == 1)
                    p.Append(Digits[rand.Next(1, 10)]);
                if (i == length - 1)
                    p.Append(PrimeEndings[rand.Next(3)]);
                else
                    p.Append(Digits[rand.Next(10)]);
            }
            return BigInteger.Parse(p.ToString());
        }
        public static bool IsPrime(BigInteger p, int length)
        {
            var a = GenerateRandomWithString(length / 2);
            if (a < 2)
                a = 2;
            return BigInteger.ModPow(a, (p - 1), p) == 1;
        }

    }
}
