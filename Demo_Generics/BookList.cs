using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Generics
{
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }
        public class GenericList<T> { 
            public void Add(T value)
            {

            }
            public T this[int index]
            {
                get (throw new NotImplementedException);
            }
        }
    }
}
