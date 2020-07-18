using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore.Interfaces;

namespace AlgorithmsCore.Sorting
{
    public abstract class BaseSort : ISort
    {
        public abstract void Sort(IComparable[] a);

        public void Print(IComparable[] a)
        {
            var length = a.Length;
            Console.Write("[");
            for (int i = 0; i < length; i++)
            {
                Console.Write(a[i]);
                if (i != length - 1)
                    Console.Write(", ");
                else
                    Console.WriteLine("]");
            }
        }

        public bool IsLess(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        public bool IsSorted(IComparable[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (!IsLess(a[i], a[i + 1]))
                    return false;
            }
            return true;
        }

        public void Exchange(IComparable[] a, int i, int j)
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
