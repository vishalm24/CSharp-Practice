namespace ExtensionMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Let's try shortning string using extension method
            string input = "This is very long long long long long long long long long long string";
            string output = input.Shorten(5);
            Console.WriteLine(output+"...");
        }
    }
}
//If we obserrve linq methods they are Extension Methods
