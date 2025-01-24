using GenericsWthConstraints.Models;
using GenericsWthConstraints.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWthConstraints
{
    //where T: class
    //Uses Class_Utility.cs
    //Ensures the type is in a class, inteface, delegate, or arrays.
    //Basically it ensures type is a reference type.
    internal class ClassConstraint
    {
        public void ClassObject()
        {
            Product product = new Product("Title", 67);
            Class_Utility<Product> GenClass = new Class_Utility<Product>(product);
            Console.WriteLine($"Title of a GenClass instance is {GenClass.GetInstance().Title}");
            Console.WriteLine();
            GenClass.SetInstance(new Product("Ikea Table", 4000));
            Console.WriteLine("After changing instance: ");
            Console.WriteLine($"Title of a GenClass instance is {GenClass.GetInstance().Title}");
        }
    }
}
