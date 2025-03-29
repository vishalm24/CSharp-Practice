using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ModelsWithData
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Lazy<List<Order>> Orders { get; set; }
        public Customer()
        {

        }
    }
}
