using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWthConstraints.Models
{
    internal class Product
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public Product(string _Title, float _Price)
        {
            Title = _Title;
            Price = _Price;
        }
    }
}
