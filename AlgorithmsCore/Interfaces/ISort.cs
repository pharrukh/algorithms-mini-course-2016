using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore.Interfaces
{
    public interface ISort
    {
        void Sort(IComparable[] a);
        void Print(IComparable[] a);
        bool IsLess(IComparable v, IComparable w);
        bool IsSorted(IComparable[] a);
        void Exchange(IComparable[] a, int i, int j);
    }
}
