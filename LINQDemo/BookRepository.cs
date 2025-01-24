using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title = "ADO.Net Step by Step", Price = 5},
                new Book(){Title = "ASP.Net MVC", Price = 9.99f},
                new Book(){Title = "ASP.Net Web API", Price = 12},
                new Book(){Title = "C# Advanced Topics", Price = 7},
                new Book(){Title = "C# Advanced Topics", Price = 9}
            };
        }
    }
}
