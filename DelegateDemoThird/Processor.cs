using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoThird
{
    internal class Processor
    {
        public void Process(int num1, int num2, Action<int, int> operationHandler)
        {
            operationHandler(num1, num2);
        }

        //Normal way of delegate:
        //public delegate void OperationHandler(int num1, int num2);
        //public void Process(int num1, int num2, OperationHandler operationHandler)
        //{
        //    operationHandler(num1, num2);
        //}
    }
}
