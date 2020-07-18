using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore.Sorting
{
    public class MaksimSort : BaseSort
    {
        public override void Sort(IComparable[] a)
        {
            bool isSorted = false;
            while (isSorted == false)
            {
                bool didExchange = false;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (!IsLess(a[i], a[i + 1]))
                    {
                        Exchange(a, i, i + 1);
                        didExchange = true;
                    }
                }
                if (didExchange == false)
                    isSorted = true;
            }
        }
    }
}
