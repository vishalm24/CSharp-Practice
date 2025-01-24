using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class Photo
    {
        //Load is static method having Photo as return type.
        //And we are returning instance of Photo class by calling load method.
        public static Photo Load(string path)
        {
            return new Photo();
        }
        public void Save() { }
    }
}
