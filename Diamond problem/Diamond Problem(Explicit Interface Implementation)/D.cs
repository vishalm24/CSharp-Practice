using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Problem_Explicit_Interface_Implementation_
{
    internal class D : B, IA //Explicitly implementing IA interface and implement it's method
    {
        void IA.show()
        {
            Console.WriteLine("This is Class D Implementation");
        }
    }
}
