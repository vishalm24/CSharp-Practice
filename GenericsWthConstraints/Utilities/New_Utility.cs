using GenericsWthConstraints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWthConstraints.Utilities
{
    //where T: new()
    //The new() constraint ensures that parameter has a public parameterless constructor.
    //This is useful when we need to create instances of the generic type within the class.
    internal class New_Utility<T> where T: new()
    {
        private T _instance;
        public New_Utility()
        {
            _instance = new T();
        }
        public T GetInstance()
        {
            return _instance;
        }
    }
}
