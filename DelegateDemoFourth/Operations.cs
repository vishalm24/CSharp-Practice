using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DelegateDemoFourth
{
    internal class Operations
    {
        public int Addition(int num1, int num2)
        {
            return (num1 + num2);
        }
        public int Substraction(int num1, int num2)
        {
            return (num1 - num2);
        }
        public int Multiplication(int num1, int num2)
        {
            return (num1 * num2);
        }
        public int Division(int num1, int num2)
        {
            return (num1 / num2);
        }

        ////For normal way to do delegate
        //public void Addition(int num1, int num2, ref List<int> output)
        //{
        //    output.Add(num1 + num2);
        //}
        //public void Substraction(int num1, int num2, ref List<int> output)
        //{
        //    output.Add(num1 - num2);
        //}
        //public void Multiplication(int num1, int num2, ref List<int> output)
        //{
        //    output.Add(num1 * num2);
        //}
        //public void Division(int num1, int num2, ref List<int> output)
        //{
        //    output.Add(num1 / num2);
        //}
    }
}
