using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore
{
    public static class NumberHelpers
    {
        public static int GetSumOfDigits(string number)
        {
            var sum = 0;
            for (var i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number.Substring(i, 1));
            }
            return sum;
        }

        public static BigInteger Factorial(int n)
        {
            var factorial = 1;
            for (var i = 1; i <= n; i++)
                factorial *= i;
            return factorial;
        }
    }
}
