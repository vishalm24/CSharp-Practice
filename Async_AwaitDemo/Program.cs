namespace Async_AwaitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's start tasks: ");
            method1();
            method2();
            Console.WriteLine("Tasks completed");
            Console.ReadLine();
        }
        static async void method1()
        {
            Console.WriteLine("First task started...");
            int j = 0;
            //await Task.Run(() =>
            await Task.Delay(1000);
            //{
                for (int i = 0; i < 1000; i++)
                {
                    if (i % 10 == 0)
                    {
                        j++;
                        Console.WriteLine("First Task " + j);
                    }
                }
                Console.WriteLine("First task has been ended...");
            //});
        }
        static async void method2()
        {
            Console.WriteLine("Second task started...");
            int j = 0;
            //await Task.Run(() =>
            await Task.Delay(1000);
            //{
                for (int i = 0; i < 1000; i++)
                {
                    if (i % 10 == 0)
                    {
                        j++;
                        Console.WriteLine("Second Task " + j);
                    }
                }
                Console.WriteLine("Second task has been ended...");
            //});
            
        }
    }
}
