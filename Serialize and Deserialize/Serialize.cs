using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize_and_Deserialize
{
    internal class Serialize
    {
        DataClass DC = new DataClass();
        string path = @"C:\Users\Nimap\Desktop\serialize.txt";
        FileInfo file = new FileInfo(@"C:\Users\Nimap\Desktop\serialize.txt");
        Stream stream = file.Open(FileMode.Create);

    }
}
