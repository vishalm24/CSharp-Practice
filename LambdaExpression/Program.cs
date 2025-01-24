namespace LambdaExpression
{
    internal class Program
    {
        //Let's run code using lambda expression
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price < 10);
            //This is working similarly as predicate but difference
            //is that we don't need to create a method for boolean.
            //FindAll is working for finding set of data which have
            //perticular specifications.
            foreach(var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        ////This is implementation of predicate
        //static void Main(string[] args)
        //{
        //    var books = new BookRepository().GetBooks();
        //    var cheapBooks = books.FindAll(PriceLessThan10Dollars);
        //    //This is predicate as we can see books.FindAll called a method
        //    //PriceLessThan10Dollars which gives boolean value to check
        //    //weather it satisfies the condition or not and then if it's
        //    //true then predicate gives current object or value.
        //    foreach (var book in cheapBooks)
        //    {
        //        Console.WriteLine(book.Price);
        //    }
        //}
        //static bool PriceLessThan10Dollars(Book book)
        //{
        //    return book.Price<10;
        //}//checking weather Price is less than 10 or not. and returning bool to calling method.
    }
}
