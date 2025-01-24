using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoSecond
{
    internal class Video
    {
        public static Video Load(string path)
        {
            return new Video();
        }
        public void Save() { }
    }
}
