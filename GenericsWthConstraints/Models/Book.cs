using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWthConstraints.Models
{
    //Right now it's just useless:
    internal class Book : Product
    {
        public Book(string _Title, float _Price) : base(_Title, _Price)
        {
        }

        public string Isbn { get; set; }
    }
}
