using System.Text;

namespace Demo_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Attempting sequence of builder methods in empty object
            //var builder = new StringBuilder();
            //builder.Append('-', 10);//Appends the character, first value is character and 2nd is repetation of value
            //builder.AppendLine();
            //builder.Append("Header");
            //builder.AppendLine();
            //builder.Append('-', 10);
            //builder.Replace("-", "+");//Replace string from - to +
            //builder.Remove(0, 10); //First is start index and 2nd is length
            //builder.Insert(0, new string('-', 10));//Insert string at given index, inside new string 1st is index and 2nd is string
            //Console.WriteLine(builder);

            ////Attempting sequence of builder methods in "Hello World!" StringBuilder object
            //var builder = new StringBuilder("Hello World!");
            //builder.Append('-', 10);
            //builder.AppendLine();
            //builder.Append("Header");
            //builder.AppendLine();
            //builder.Append('-', 10);
            //builder.Replace("-", "+");
            //builder.Remove(0, 10);
            //builder.Insert(0, new string('-', 10));
            //Console.WriteLine(builder);
            //Console.WriteLine(builder[0]);

            ////We can join all methods in following sequence:
            //var builder = new StringBuilder("Hello World!");
            //builder.Append('-', 10)
            //.AppendLine()
            //.Append("Header")
            //.AppendLine()
            //.Append('-', 10)
            //.Replace("-", "+")
            //.Remove(0, 10)
            //.Insert(0, new string('-', 10));
            //Console.WriteLine(builder);
            //Console.WriteLine(builder[0]);
        }
    }
}
