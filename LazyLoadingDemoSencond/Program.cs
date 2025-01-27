namespace LazyLoadingDemoSencond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lazy<Test> lazy = new Lazy<Test>();
            Console.WriteLine("Date Loaded: "+ lazy.IsValueCreated);
            Test t = lazy.Value;
            foreach (var item in t.names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
