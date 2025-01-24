using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Demo_FileStream
{
    
    internal class Program
    {
        //I used async just for demo of Task delay wait in FileStream demo.
        //If we remove this and all task methods then it wont be a problem at all.
        static async Task Main(string[] args)
        {
            ////File
            ////This is demo of file method for saving data in file.
            //var path = @"C:\Users\Nimap\Desktop\Lorem Ipsum.txt";
            //using (StreamWriter sw = File.CreateText(path))
            //{
            //    sw.WriteLine("This is for demonstration of creating a file and saving data in it.");
            //    sw.WriteLine("Hello My name is Vishal Ganesh Murudkar");
            //    sw.WriteLine("This are just 3 lines for demo");
            //}
            //StringBuilder sb = new StringBuilder();
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string output = "";
            //    while((output = sr.ReadLine())!= null)
            //    {
            //        sb.AppendLine(output);
            //        Console.WriteLine(output);
            //        //Here we can do both either console write or saving data in string builder
            //    }
            //}
            //Console.WriteLine(sb);

            ////FileInfo
            ////This is demonstration of saving data in file using FileInfo instance
            //var path = @"C:\Users\Nimap\Desktop\Lorem Ipsum.txt";
            //FileInfo fi = new FileInfo(path);
            //using (StreamWriter sw = fi.CreateText())
            //{
            //    sw.WriteLine("This is for demonstration of creating a file and saving data in it.");
            //    sw.WriteLine("Hello My name is Vishal Ganesh Murudkar");
            //    sw.WriteLine("This are just 3 lines for demo");
            //}
            //using (StreamReader sr = fi.OpenText())
            //{
            //    string output = "";
            //    while ((output = sr.ReadLine())!= null)
            //    {
            //        Console.WriteLine(output);
            //    }
            //}

            ////FileStream
            ////Let's creeate program for creating file using filestream writing data and read data.
            //FileStream fwrite = new FileStream(@"C:\Users\Nimap\Desktop\DemoFile", FileMode.Create, FileAccess.Write, FileShare.None);
            //Console.WriteLine("File is created...");
            //Task.Delay(1000).Wait();
            //var text = "This is a code for demonstration of file stream program.";
            //byte[] writeArr = Encoding.UTF8.GetBytes(text);
            //fwrite.Write(writeArr, 0, text.Length);
            //fwrite.Close();
            //Console.WriteLine("File with data is stored to location...");
            //Task.Delay(1000).Wait();
            //FileStream fread = new FileStream(@"C:\Users\Nimap\Desktop\DemoFile", FileMode.Open, FileAccess.Read, FileShare.None);
            //Console.WriteLine("Getting data from file...");
            //Task.Delay(1000).Wait();
            //byte[] readArr = new byte[text.Length];
            //int count;
            //while ((count = fread.Read(readArr, 0, readArr.Length)) > 0)
            //{
            //    Console.WriteLine(Encoding.UTF8.GetString(readArr, 0, count));
            //}
            //fread.Close();
            ////Output
            ////File is created...
            ////File with data is stored to location...
            ////Getting data from file...
            ////This is a code for demonstration of file stream program.
        }
    }
}

