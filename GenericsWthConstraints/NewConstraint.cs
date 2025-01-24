using GenericsWthConstraints.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWthConstraints
{
    //where T: new()
    //Uses New_Utility.cs
    //The new() constraint ensures that parameter has a public parameterless constructor.
    //This is useful when we need to create instances of the generic type within the class.
    internal class NewConstraint
    {
        public void ParameterlessInstance()
        {
            New_Utility<object> n = new New_Utility<object>();
            Console.WriteLine($"Instance: {n.GetInstance()}");
        }
    }
}
