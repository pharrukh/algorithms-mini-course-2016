using System;
using System.Numerics;

namespace AlgorithmsCore
{
    public static partial class Algorithms
    {
        //private static readonly BigInteger p = BigInteger.Parse("12131072439211271897323671531612440428472427633701410925634549312301964373042085619324197365322416866541017057361365214171711713797974299334871062829803541");
        //private static readonly BigInteger q = BigInteger.Parse("12027524255478748885956220793734512128733387803682075433653899983955179850988797899869146900809131611153346817050832096022160146366346391812470987105415233");
        //private static readonly BigInteger e = 65537;
        //private static readonly BigInteger d = BigInteger.Parse("89489425009274444368228545921773093919669586065884257445497854456487674839629818390934941973262879616797970608917283679875499331574161113854088813275488110588247193077582527278437906504015680623423550067240042466665654232383502922215493623289472138866445818789127946123407807725702626644091036502372545139713");

        public static Keys RSAGetKeys()
        {
            var p = GetBigPrime(100);
            var q = GetBigPrime(100);
            //n = p * q
            var n = BigInteger.Multiply(p, q);
            //phi(n) = (p-1)*(q-1)
            var totient = BigInteger.Multiply((p - 1), (q - 1));
            var e = GetPublicKey(totient);
            var d = GetPrivateKey(totient, e);
            return new Keys(e, d, n);
        }
        public static BigInteger[] Extended_GCD(BigInteger A, BigInteger B)
        {
            BigInteger[] result = new BigInteger[3];
            if (A < B) //if A less than B, switch them
            {
                BigInteger temp = A;
                A = B;
                B = temp;
            }
            BigInteger r = B;
            BigInteger q = 0;
            BigInteger x0 = 1;
            BigInteger y0 = 0;
            BigInteger x1 = 0;
            BigInteger y1 = 1;
            BigInteger x = 0, y = 0;
            while (r > 1)
            {
                r = A % B;
                q = A / B;
                x = x0 - q * x1;
                y = y0 - q * y1;
                x0 = x1;
                y0 = y1;
                x1 = x;
                y1 = y;
                A = B;
                B = r;
            }
            result[0] = r;
            result[1] = x;
            result[2] = y;
            return result;
        }
        public static BigInteger GetPublicKey(BigInteger totient)
        {
            var length = (50);
            BigInteger e = 5;
            do
            {
                e = GetBigPrime(length);
                if (BigInteger.GreatestCommonDivisor(e, totient) == 1)
                    return e;
            } while (true);
        }
        public static BigInteger GetPrivateKey(BigInteger totient, BigInteger e)
        {
            BigInteger[] d = new BigInteger[3];
            d = Extended_GCD(totient, e);
            if (d[2] < 0)
                d[2] = d[2] + totient;
            return d[2];
        }
        public static BigInteger RSAEncrypt(BigInteger public_key, BigInteger n, BigInteger message)
        {
            return BigInteger.ModPow(message, public_key, n);
        }
        public static BigInteger RSADecrypt(BigInteger private_key, BigInteger n, BigInteger message)
        {
            return BigInteger.ModPow(message, private_key, n);
        }
    }

    public class Keys
    {
        private BigInteger public_key;
        private BigInteger private_key;
        private BigInteger modulus;

        public Keys(BigInteger pub_key, BigInteger priv_key, BigInteger mod)
        {
            public_key = pub_key;
            private_key = priv_key;
            modulus = mod;
        }

        public BigInteger GetPublicKey()
        {
            return public_key;
        }
        public BigInteger GetPrivateKey()
        {
            return private_key;
        }
        public BigInteger GetModulus()
        {
            return modulus;
        }
    }
}
