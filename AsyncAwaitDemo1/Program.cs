namespace AsyncAwaitDemo1
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Method1();
            Task<int> temp = Method1();
            Method2();
            int count = await temp;
            Method3(count);
        }
        public static async Task<int> Method1()
        {
            int count = 0;

            await Task .Run(()=> {
                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine("This is Method1");
                    count++;
                }
            });
            return count;
        }
        static void Method2()
        {
            for(int i = 0; i < 25; i++)
            {
                Console.WriteLine("This is Method2");
            }
        }
        static void Method3(int count){
            Console.WriteLine("Count of execution"+ count);
        }
    }
}
