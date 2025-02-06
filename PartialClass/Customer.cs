using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal class Customer
    {
        private string firstName;
        private string lastName;
        //Following this is same as get and set.
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string GetFullName()
        {
            return firstName+" "+lastName;
        }
    }
}
