using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal partial class PartialCustomer
    {
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
}
