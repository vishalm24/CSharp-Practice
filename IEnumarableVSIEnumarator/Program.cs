namespace IEnumarableVSIEnumarator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Let's make a code which shows difference between IEnumarable and Ienumarator
            //IEnumarator
            List<int> oyears = new List<int>();
            oyears.Add(1994);
            oyears.Add(1995);
            oyears.Add(1996);
            oyears.Add(1997);
            oyears.Add(1998);
            oyears.Add(1999);
            oyears.Add(2000);
            oyears.Add(2001);
            oyears.Add(2002);
            oyears.Add(2003);
            oyears.Add(2004);
            oyears.Add(2005);
            ////For IEnumarator:
            IEnumerator<int> enumerator = oyears.GetEnumerator();
            ////Following won't be going to work. Because we have to use while(enumerator.MoveNext())
            ////for initializing and for moving to the next iteration.
            //int i = 0;
            //while (enumerator.MoveNext())
            //{
            //    i++;
            //}
            //for (int j = 0; j < i; j++)
            //{
            //    enumerator.MoveNext();
            //    Console.WriteLine(enumerator.Current.ToString());
            //}
            //Enumarator(enumerator);
            ////For IEnumarable
            //IEnumerable<int> enumerable = (IEnumerable<int>)oyears;
            //Enumerable(enumerable);
            Console.ReadLine();
        }
        ////IEnumerable:
        ////We want to print iEnumarable till 1999 from using method:
        //static void Enumerable(IEnumerable<int> O)
        //{
        //    Console.WriteLine("Printing years till 1999");
        //    foreach (int item in O)
        //    {
        //        Console.WriteLine(item);
        //        if (item > 2000)
        //        {
        //            EnumerableNext(O);
        //        }
        //    }
        //}
        ////This method prints from 2000
        //static void EnumerableNext(IEnumerable<int> O)
        //{
        //    Console.WriteLine("Printing years from 2000");
        //    foreach (var item in O)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        ////IEnumarator:
        ////This method prints till 1999
        //static void Enumarator(IEnumerator<int> O)
        //{
        //    Console.WriteLine("Printing years till 1999");
        //    while (O.MoveNext())
        //    {
        //        Console.WriteLine(O.Current.ToString());
        //        if (Convert.ToInt16(O.Current) > 2000)
        //        {
        //            EnumaratorNext(O);
        //        }
        //    }
        //}
        ////This method prints from 2000
        //static void EnumaratorNext(IEnumerator<int> O)
        //{
        //    Console.WriteLine("Printing years from 2000");
        //    while (O.MoveNext())
        //    {
        //        Console.WriteLine(O.Current.ToString());
        //    }
        //}
    }
}
