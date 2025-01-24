using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWthConstraints.Utilities
{
    //where T: class
    //Ensures the type is in a class, inteface, delegate, or arrays.
    //Basically it ensures type is a reference type.
    //new() constraint is also applicable in class constraint
    internal class Class_Utility<T> where T: class
    {
        private T _instance;
        public Class_Utility(T instance)
        {
            _instance = instance;
        }
        public T GetInstance()
        {
            return _instance;
        }
        public void SetInstance(T instance)
        {
            _instance = instance;
        }
    }
}
