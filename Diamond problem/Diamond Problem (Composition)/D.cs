using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Problem__Composition_
{
    internal class D
    {
        private B b = new B();
        private C c = new C();
        public void show()
        {
            b.a.show();//Using A's method via B
            c.a.show();//Using A's method via C
        }
    }
}
