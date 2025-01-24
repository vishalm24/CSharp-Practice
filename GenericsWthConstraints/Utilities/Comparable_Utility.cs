using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWthConstraints.Utilities
{
    //where T: IComparable
    //Enables compare inteface
    ////This is the one way to do it for normal class:
    //public class Comparable_Utility
    //{
    //    //Normal way to do it if we has to do it with interger values:
    //    public int Max(int a, int b)
    //    {
    //        return a > b ? a : b;
    //    }

    //    //Now we are going to implement same method with generics:
    //    public T Max<T>(T a, T b) where T : IComparable
    //    {
    //        return a.CompareTo(b) > 0 ? a : b;
    //    }
    //}

    //Now we are going to implement same thing but implementing generic placeholder
    public class Comparable_Utility<T> where T : IComparable
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
