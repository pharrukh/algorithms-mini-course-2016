using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore
{
    public static partial class Algorithms
    {
        public static int GetNumberOfDigits(BigInteger n)
        {
            return n.ToString().Length;
        }
    }

    public class FibMatix
    {
        private BigInteger _a11;
        private BigInteger _a12;
        private BigInteger _a21;
        private BigInteger _a22;
        private int _curFibIndex = 1;

        public FibMatix()
        {
            _a11 = 0;
            _a12 = 1;
            _a21 = 1;
            _a22 = 1;
        }

        public BigInteger GetFibNum(int i)
        {
            _curFibIndex = 1;
            BigInteger a11, a12, a21, a22;
            if (i == 1)
                return 1;
            _curFibIndex += 1;
            SetInitial();
            while (true)
            {
                if (_curFibIndex == i)
                    return _a22;
                a11 = _a11 * 0 + _a12 * 1;
                a12 = _a11 * 1 + _a12 * 1;
                a21 = _a21 * 0 + _a22 * 1;
                a22 = _a21 * 1 + _a22 * 1;
                _a11 = a11;
                _a12 = a12;
                _a21 = a21;
                _a22 = a22;
                _curFibIndex++;
            }
        }
        public BigInteger CurrentFibNumber()
        {
            return _a22;
        }
        public BigInteger CurrentIndex()
        {
            return _curFibIndex;
        }
        private void SetInitial()
        {
            _a11 = 0;
            _a12 = 1;
            _a21 = 1;
            _a22 = 1;
        }
        public List<BigInteger> GenerateFibNum(int n)
        {
            var fibSeq = new List<BigInteger>() { 1 };
            if (n == 1)
                return fibSeq;
            fibSeq.Add(_a22);
            if (n == 2)
                return fibSeq;
            SetInitial();
            BigInteger a11, a12, a21, a22;
            for (var j = 1; j < n - 1; j++)
            {
                a11 = _a11 * 0 + _a12 * 1;
                a12 = _a11 * 1 + _a12 * 1;
                a21 = _a21 * 0 + _a22 * 1;
                a22 = _a21 * 1 + _a22 * 1;
                _a11 = a11;
                _a12 = a12;
                _a21 = a21;
                _a22 = a22;
                _curFibIndex++;
                fibSeq.Add(_a22);
            }
            return fibSeq;
        }
    }
}
