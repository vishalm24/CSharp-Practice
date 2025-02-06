using System.Collections.Concurrent;

namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of class Customer:");
            Customer cust = new Customer() { FirstName = "Vishal", LastName = "Murudkar" };
            Console.WriteLine($"Name: {cust.GetFullName()}");
            Console.WriteLine("Implementation of partial class PartialCustomer:");
            PartialCustomer PCust = new PartialCustomer() { firstName = "Bhavesh", lastName = "Gharat"};
            Console.WriteLine($"Name: {PCust.GetFullName()}");
        }
    }
}
