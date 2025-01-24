using GenericsWthConstraints.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWthConstraints
{
    //where T: struct
    //Uses Struct_Utility.cs
    //Ensure generic type is a non-nullable value type like int, float, double, or a custom struct
    internal class StructConstraint
    {
        public void nullable()
        {
            //For null
            Struct_Utility<int> st = new Struct_Utility<int>();
            Console.WriteLine("st instance has value: "+st.HasValue);
            Console.WriteLine($"st has value: {st.GetValueOrDefault()}");
            Console.WriteLine();

            //For double
            Struct_Utility<double> st1 = new Struct_Utility<double>(78);
            Console.WriteLine("st1 instance has value: " + st1.HasValue);
            Console.WriteLine($"st1 has value: {st1.GetValueOrDefault()}");
        }
    }
}
