using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public Book(string _Title, int _Price) {
            Title = _Title;
            Price = _Price;
        }
        public Book() { }
    }
}
