namespace Diamond_Problem_Explicit_Interface_Implementation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IA d = new D();
            d.show();//Calls D's show()
        }
    }
}
