using ConsoleApp1.ModelsWithData;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For checking the lazy loading we just have to see local window where we can observer the value in custome orders.
            Object_Initializer obj = new Object_Initializer();
            var customers = obj.customers();
            foreach (var cust in customers)
            {
                Console.WriteLine("Name of customer = " + cust.Name);
            }
            foreach (var cust in customers)
            {
                Console.WriteLine("Name of customer = " + cust.Name);
                //It is required to call the value property to load the orders.
                foreach (var item in cust.Orders.Value)
                {
                    Console.WriteLine("Name of Items: " + item.Name + ", Price = " + item.Price);
                }
            }
        }
    }
}
