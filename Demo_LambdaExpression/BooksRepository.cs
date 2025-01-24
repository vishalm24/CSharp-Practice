using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LambdaExpression
{
    //Here we creted a repository which gets books data  but for now we are going to put values hard coded.
    internal class BooksRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>{
                new Book(){Title = "Title 1",Price = 5},
                new Book(){Title = "Title 2",Price = 7},
                new Book(){Title = "Title 1",Price = 17}
            };
        }
    }
}
