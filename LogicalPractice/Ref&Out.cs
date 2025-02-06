using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class Ref_Out
    {
        
        public void inputparmeter()
        {
            int i = 15;
            inputpara input = new inputpara();
            input.input1(out i);
            Console.WriteLine(i); 
        }
    }
    public class inputpara
    {
        public void input1(out int num)
        {
            //Console.WriteLine(num);//Error
            num = 17;
            Console.WriteLine(num);
        }
    }
}
