namespace Demo_Directory
{
    internal class Program
    {
        //Demo of Directory and DirectoryInfo
        static void Main(string[] args)
        {
            ////Directory
            ////Getting all files inside that directory
            //var files = Directory.GetFiles(@"C:\Users\Nimap\Desktop\Notes", "*.*", SearchOption.AllDirectories);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}
            ////Getting all diretories present in that directory
            //var directories = Directory.GetDirectories(@"C:\Users\Nimap\Desktop\Notes", "*.*", SearchOption.AllDirectories);
            //foreach (var directory in directories)
            //{
            //    Console.WriteLine(directory);
            //}
            ////Creating new Directory in perticular directory
            //Directory.CreateDirectory(@"C:\Users\Nimap\Desktop\Notes\MyNotes");

            ////DirectoryInfo
            //DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Nimap\Desktop\Notes");
            //if (dir.Exists)
            //{
            //    Console.WriteLine("Input directory exists...");
            //}
        }
    }
}
