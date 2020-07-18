using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore.Sorting;

namespace AlgorithmTests.SortingTests
{
    public class JahongirSort : BaseSort
    {
        public override void Sort(IComparable[] a)
        {
            var collectionLength = a.Length;
            for (int i = 0; i < collectionLength; i++)
            {
                for (int j = 0; j < collectionLength - 1; j++)
                {
                    if (!IsLess(a[j], a[j + 1]))
                        Exchange(a, j, j + 1);
                }
            }
        }
    }
}
