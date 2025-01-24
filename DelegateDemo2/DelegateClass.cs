using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo2
{
    public delegate void DelegateHandler();
    internal class DelegateClass
    {
        public void delegates(int val1, int val2, DelegateHandler operationHandler)
        {
            var operations = new Operations();
            operationHandler();
        }
    }
}
