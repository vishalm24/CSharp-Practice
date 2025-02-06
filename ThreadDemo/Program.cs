namespace ThreadDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(PerformThread);
            Thread thread2 = new Thread(PerformThread);
            thread1.Start();
            thread2.Start();
            //If we use Join() on thread object it blocks code till thread execution is done.
            //thread1.Join();
            //thread2.Join();
            Console.WriteLine("Execution is done");
        }
        static void PerformThread()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Task completed on thread: " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
