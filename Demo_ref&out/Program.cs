namespace Demo_ref_out
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int number = 4;
        //    var data = OutNethod(ref number);
        //    Console.WriteLine(number);
        //}
        //public static int OutNethod(ref int x)
        //{
        //    x += 1;
        //    int num = x;
        //    return num;
        //}
        //static void Main(string[] args)
        //{
        //    int number = 4;
        //    var data = OutNethod(out number);
        //    Console.WriteLine(number);
        //}
        //public static int OutNethod(out int x)
        //{
        //    x = 1;
        //    int num = x;
        //    return num;
        //}

        
        static void Main(String[] args)
        {
            ////String practice: string join
            //string name = "Vishal";
            //var input = new String[3] { "Vishal", "Ganesh", "Sumit" };
            //var inputvalues = String.Join(",", input);
            //Console.WriteLine(inputvalues);

            ////Array and List Exercise:
            ////1- Write a program to count how many numbers between 1 and 100 are divisible by 3
            ////with no remainder. Display the count on the console.
            //for(int i = 1; i<=100; i++)
            //{
            //    if(i%3 == 0)
            //    {
            //        Console.Write(i + ", ");
            //    }
            //}

            ////2- Write a program and continuously ask the user to enter a number or "ok" to exit.
            ////Calculate the sum of all the previously entered numbers and display it on the console.
            //List<int> li = new List<int>();
            //while(true)
            //{
            //    Console.WriteLine("Please enter values to be stored.");
            //    string str = Console.ReadLine();
            //    if (str != "ok")
            //    {
            //        li.Add(Convert.ToInt32(str));
            //        continue;
            //    }
            //    else if(str == "ok")
            //    {
            //        break;
            //    }
            //}
            //foreach (var item in li)
            //{
            //    Console.WriteLine(item);
            //}

            ////3- Write a program and ask the user to enter a number. Compute the factorial of
            ////the number and print it on the console. For example, if the user enters 5, the
            ////program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            //Console.WriteLine("Please enter the value");
            //int input = Convert.ToInt32(Console.ReadLine());
            //int output = 1;
            //for (int i = 1; i <= input; i++)
            //{
            //    output *= i;
            //}
            //Console.WriteLine("Factorial of "+input+" is "+output);

            ////4- Write a program that picks a random number between 1 and 10. Give the user 4
            ////chances to guess the number. If the user guesses the number, display “You won";
            ////otherwise, display “You lost". (To make sure the program is behaving correctly,
            ////you can display the secret number on the console first.)
            //Random random = new Random();
            //int number = random.Next(1, 10);
            //Console.WriteLine("Random number is "+ number);
            //Console.WriteLine("Guess the number: You have 4 chances!");
            //bool flag = false;
            //for(int i =1; i<=4; i++)
            //{
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    if(number == input)
            //    {
            //        Console.WriteLine("You won");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You lost");
            //        flag = true;
            //    }
            //}
            //if(flag == false)
            //{
            //    Console.WriteLine("Out of luck");
            //}

            ////5- Write a program and ask the user to enter a series of numbers separated
            ////by comma. Find the maximum of the numbers and display it on the console.
            ////For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            //List<int> li = new List<int>();
            //Console.WriteLine("Please enter interger values separated by comma:");
            //string input = Console.ReadLine();
            //foreach (var item in input.Split(","))
            //{
            //    li.Add(Convert.ToInt32(item));
            //}
            //int max = li[0];
            //for(int i = 1; i<li.Count; i++)
            //{
            //    if (li[i] > max)
            //    {
            //        max = li[i];
            //    }
            //}
            //Console.WriteLine("Maximum value in given input is "+max);

            ////Array practice:
            ////Length:
            //int[] numbers = {5, 6, 4, 6, 3, 8};
            //Console.WriteLine(numbers.Length);

            ////IndexOf:
            //int[] numbers = { 5, 6, 4, 6, 3, 8 };
            //Console.WriteLine(Array.IndexOf(numbers, 6));

            ////Clear:
            //int[] numbers = { 5, 6, 4, 6, 3, 8 };
            //Array.Clear(numbers, 0, 2);
            //foreach(int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //Copy:
            //int[] numbers = { 5, 6, 4, 6, 3, 8 };
            //int[] num = new int[numbers.Length];
            //Array.Copy(numbers, num, 4);
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}

            ////Sort()
            //int[] numbers = { 5, 6, 4, 6, 3, 8 };
            //Array.Sort(numbers);
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            ////Reverse()
            //int[] numbers = { 5, 6, 4, 6, 3, 8 };
            //Array.Reverse(numbers);
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            ////List:
            ////Add()
            //List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //input.Add(11);
            //foreach (var item in input)
            //{
            //    Console.WriteLine(item);
            //}

            ////AddRange()
            //List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //input.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
            //foreach (var item in input)
            //{
            //    Console.WriteLine(item);
            //}

            ////Clear()
            //List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //input.Clear();
            //input.Add(25);
            //foreach (var item in input)
            //{
            //    Console.WriteLine(item);
            //}

            ////Find(Predicate x => x>2); this gets first occurance value
            ////FindAll(Predicate x => x>2); this gets a list of all values which are eligible in current expression
            //List<int> input = new List<int>() { 1, 2, 20, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(input.Find(x => x > 2));
            //List<int> numbers = input.FindAll(x => x>2);
            //foreach (int i in numbers)
            //{
            //    Console.Write(i+", ");
            //}

            ////IndexOf()
            //List<int> input = new List<int>() { 1, 2, 20, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(input.IndexOf(20));

            ////Insert(index, value)
            //List<int> input = new List<int>() { 1, 2, 20, 4, 5, 6, 7, 8, 9, 10 };
            //input.Insert(2, 61);
            //foreach (var item in input)
            //{
            //    Console.WriteLine(item);
            //}

            ////Remove() removes perticular value
            ////RemoveAt() removes value at index
            //List<int> input = new List<int>() { 1, 2, 20, 4, 5, 6, 7, 8, 9, 10, 20};
            ////input.Remove(3);// removed perticular value
            ////input.RemoveAt(1); //removes value at index
            //input.RemoveAll(x => x == 20); // removes all value eligible for expression
            //foreach (var item in input)
            //{
            //    Console.WriteLine(item);
            //}

            ////Sort()
            //List<int> input = new List<int>() { 1, 2, 20, 4, 5, 6, 7, 8, 9, 10, 20 };
            //input.Sort();
            //foreach (var item in input)
            //{
            //    Console.WriteLine(item);
            //}

            ////ToArrray()
            //List<int> input = new List<int>() { 1, 2, 20, 4, 5, 6, 7, 8, 9, 10, 20 };
            //int[] arr = input.ToArray();
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            ////Contains() Gives boolean value weather it contains a perticular value or not
            //List<int> input = new List<int>() { 1, 2, 20, 4, 5, 6, 7, 8, 9, 10, 20 };
            //Console.WriteLine(input.Contains(55)? "Contains": "Not Contains");

            ////Count() Gives a count of total elements of list just like Length gives length of array and string
            //List<int> input = new List<int>() { 1, 2, 20, 4, 5, 6, 7, 8, 9, 10, 20 };
            //Console.WriteLine(input.Count());
        }
    }
}
