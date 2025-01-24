namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trying some LINQ Extension Methods:
            var books = new BookRepository().GetBooks();
            var bookData = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(bookData.Title+" "+bookData.Price);
            //There are some other Extensions try it later
            //This are used for pagination.
            //It skips perticular number of data and take data:
            Console.WriteLine("Following data has been used for pagination:");
            var pagedBooks = books.Skip(2).Take(3);
            foreach (var pageBook in pagedBooks)
            {
                Console.WriteLine(pageBook.Title+" "+pageBook.Price);
            }
            //Let's find maximum price:
            var maxPricedBook = books.FirstOrDefault(b => b.Price == books.Max(b => b.Price));
            Console.WriteLine("Highly priced book is "+maxPricedBook.Title);
            //Count()
            var TotalBooks = books.Count();
            Console.WriteLine("Total books in shop are "+TotalBooks);
            //Sum()
            var TotalPrice = books.Sum(b => b.Price);
            Console.WriteLine("Total price of all books is "+TotalPrice);
            //Average()
            var avg = books.Average(b => b.Price);
            Console.WriteLine("Average of book's price is "+avg);

            ////LINQ Query Operators:
            //var books = new BookRepository().GetBooks();
            //var cheapBooks = from b in books
            //                 where b.Price < 10
            //                 orderby b.Title
            //                 select b;
            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine(book.Title + " " + book.Price);
            //}

            ////LINQ Extention Method:
            ////Here Select query is powerful we get data and pass 
            ////only single column and their datatype will be there
            ////Otherwise it will be object.
            //var books = new BookRepository().GetBooks();
            //var cheapBoooks = books.Where(b => b.Price < 10)
            //    .OrderBy(b => b.Title)
            //    .Select(b => b.Title);
            //foreach (var book in cheapBoooks);
            //{
            //    Console.WriteLine(book);
            //}

            ////Normal way of sorting data
            //var books = new BookRepository().GetBooks();
            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if(book.Price < 10)
            //    {
            //        cheapBooks.Add(book);
            //    }
            //}
            //foreach (var b in cheapBooks)
            //{
            //    Console.WriteLine(b.Title + " " + b.Price);
            //}
        }
    }
}
