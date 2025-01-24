using GenericsWthConstraints.Models;
using GenericsWthConstraints.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWthConstraints
{
    //where T: <base class>
    //Uses BaseClass_Utility.cs
    //Ensures that the type parameter is specific class or derived from a specific class.
    internal class BaseClassConstraint
    {
        public void BaseClass()
        {
            Console.WriteLine("Let's do discount calculation");
            Product product = new Product("Things that matters", 500);
            BaseClass_Utility<Product> BC = new BaseClass_Utility<Product>();
            int discount = 30;
            Console.WriteLine($"According to you maximum discont of {discount} price of " +
                $"{product.Title} is {BC.CalculateDiscount(product, discount)}");
        }
    }
}
