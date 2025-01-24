using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null; //If int? makes num nullable but putting null makes it null value
                             //otherwise it would be only declaration means it can be a null later.
            Console.WriteLine(num); //Just a demonstration of nullable variable.
                                    //If we didn't put null perivously after or on declaring
                                    //variable we would get an compile time error.
            var number = new Nullable<int>();
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
