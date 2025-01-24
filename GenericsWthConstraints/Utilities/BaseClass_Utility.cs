using GenericsWthConstraints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWthConstraints.Utilities
{
    //where T: <base class>
    //Uses Product.cs
    //Ensures that the type parameter is specific class or derived from a specific class.
    //new() contraint is applicable for base class constaint
    internal class BaseClass_Utility<TProduct> where TProduct : Product
    {
        //Let's find discount for a product:
        public float CalculateDiscount(TProduct product, int _Discount)
        {
            product.Discount = (100 - _Discount) / 100f;
            return product.Price * product.Discount;
        }
    }
}
