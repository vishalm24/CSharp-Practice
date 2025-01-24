using GenericsWthConstraints.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GenericsWthConstraints
{
    //where T: IComparable
    //Enables compare inteface
    internal class ComparableInterfaceConstraint
    {
        //Let's find maximum value from 2 input values
        public void Comparable_Interfaces()
        {
            Console.WriteLine("Let's find maximum nuumber between 2 numbers: ");

            ////Normal Implementation:
            //int num1 = 64;
            //int num2 = 57;
            //Comparable_Utility comparable = new Comparable_Utility();
            //int max = comparable.Max(num1, num2);
            //Console.WriteLine($"Maximum between {num1} and {num2} is {max}");

            ////Generic method Implementation:
            //int num1 = 64;
            //int num2 = 57;
            //Comparable_Utility comparable = new Comparable_Utility();
            //int max = comparable.Max<int>(num1, num2);
            //Console.WriteLine($"Maximum between {num1} and {num2} is {max}");

            //Generic class Implementation:
            int num1 = 64;
            int num2 = 57;
            Comparable_Utility<int> comparable = new Comparable_Utility<int>();
            int max = comparable.Max(num1, num2);
            Console.WriteLine($"Maximum between {num1} and {num2} is {max}");

            ////Other example for class (double)
            //double num1 = 54.75;
            //double num2 = 75.89;
            //Comparable_Utility<double> comparable = new Comparable_Utility<double>();
            //double max = comparable.Max(num1, num2);
            //Console.WriteLine($"Maximum between {num1} and {num2} is {max}");
        }
    }
}
