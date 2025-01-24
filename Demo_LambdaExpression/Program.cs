namespace Demo_LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //args => expression

            ////case 1: Printing square values
            //Func<int, int> square = number => number* number;
            ////Function <input data type, output data type> method name = passing argument => performing expression;
            //Console.WriteLine(square(5));//Output: 25

            ////case 2: Multiplying value by distinct number in this case it is factor variable
            //int factor = 5;
            //Func<int, int> multiplier = num => num * factor;
            //Console.WriteLine(multiplier(10));//Output: 50

            //case 3: Getting books which have price less than 10
            var books = new BooksRepository().GetBooks();
            var cheapbooks = books.FindAll(book => book.Price < 10);
            foreach (var item in cheapbooks)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
