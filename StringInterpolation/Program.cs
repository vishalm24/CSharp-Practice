namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Case 1:
            //int n1 = 10;
            //int n2 = 30;
            ////Normal one
            //Console.WriteLine("The sum of "+n1+" and "+n2+" is "+(n1+n2));
            ////String format
            //Console.WriteLine("The sum of {0} and {1} is {2}" , n1, n2, n1 + n2);
            ////String interpolation
            //Console.WriteLine($"The sum of {n1} and {n2} is {n1+n2}");

            ////Case 2:
            //int n1 = 10;
            //int n2 = 30;
            //string s;
            ////Normal one
            //s = "The sum of " + n1 + " and " + n2 + " is " + (n1 + n2);
            //Console.WriteLine(s);
            ////String format
            //s = String.Format("The sum of {0} and {1} is {2}", n1, n2, n1 + n2);
            //Console.WriteLine(s);
            ////String interpolation
            //s = $"The sum of {n1} and {n2} is {n1 + n2}";
            //Console.WriteLine(s);
        }
    }
}
