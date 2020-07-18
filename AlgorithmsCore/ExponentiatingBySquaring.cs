using System.Numerics;

namespace AlgorithmsCore
{
    public partial class Algorithms
    {
        public static BigInteger Power(BigInteger x, BigInteger n)
        {
            if (n == 1)
                return x;
            if (BigInteger.Remainder(n, 2) == 0)
                return Power(BigInteger.Multiply(x, x), n / 2);
            return BigInteger.Multiply(x, (Power(BigInteger.Multiply(x, x), (n - 1) / 2)));
        }
    }
}
