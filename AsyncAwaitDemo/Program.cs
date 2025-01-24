//This code is demonstrates making of breakfast.
namespace AsyncAwaitDemo
{
    // These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
    internal class Bacon { }
    internal class Coffee { }
    internal class Egg { }
    internal class Juice { }
    internal class Toast { }
    class Program
    {
        static void Main(String[] args)
        {
            ////Use normalWiat method for implimenting breakfast demonstration by wait method.
            ////But this method blocks other functions of code. That's why we need to create demonstration using Asynnc and Await
            //NormalWait nw = new NormalWait();
            //nw.normalWait();

            ////Using Async and Await in demonstration
            ////This code is good because this code doesn't block any code. But we didn't acheived concurancy in this code.
            ////For this we are going to optimize later in this file.
            //AsyncAndAwait sw = new AsyncAndAwait();
            //sw.AsyncAwait();

            ////Using Consurancy in current demo
            //Concurancy cs = new Concurancy();
            //cs.concurancy();

            ////Just for practice:
            //dynamic s = 1.34;
            //Console.WriteLine(s);
            //s = "Hello I'm Vishal";
            //Console.WriteLine(s);

            //string manipulation
            string name = "Vishal Ganesh Murudkar";
            var fName = name.Split(' ', 'G');
            foreach (var item in fName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(fName[1]+"this is my name");
        }
    }
}
