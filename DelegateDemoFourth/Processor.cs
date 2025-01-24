using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoFourth
{
    internal class Processor
    {
        public int Process(int num1, int num2, Func<int, int, int> operationHandler)
        {
            return operationHandler(num1, num2);
        }

        ////Normal way to do delegate
        //public delegate void OperationHandler(int num1, int num2, ref List<int> output);
        //public void Process(int num1, int num2, ref List<int> output, OperationHandler operationHandler)
        //{
        //    operationHandler(num1, num2, ref output);
        //}
    }
}
