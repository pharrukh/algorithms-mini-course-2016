using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore
{
    public partial class Algorithms
    {
        /// <summary>
        /// Greatest Common Divisor
        /// </summary>
        /// <param name="v"></param>
        /// <param name="u"></param>
        /// <returns></returns>
        public static BigInteger EuclidianAlgorithm(BigInteger u, BigInteger v)
        {
            if (v == 0)
                return u;
            return EuclidianAlgorithm(v, u % v);
        }
    }
}
