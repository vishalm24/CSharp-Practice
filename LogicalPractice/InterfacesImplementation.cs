using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class InterfacesImplementation: IA, IB
    {
        void IA.Add()
        {

        }
        public void Add()
        {

        }
    }
    public interface IA
    {
        public void Add();
    }
    public interface IB
    {
        public void Add();
    }
}
