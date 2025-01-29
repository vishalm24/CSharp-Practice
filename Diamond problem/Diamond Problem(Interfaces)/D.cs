using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Problem_Interfaces_
{
    internal class D : IA
    {
        private B b = new B();
        private C c = new C();
        public void show()
        {
            b.show();//B's show implementation
            c.show();//C's Show implementation
        }
    }
}
