namespace TaskDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task1 = Task.Run(() => TaskExecution());
            Task task2 = Task.Run(() => TaskExecution());
            //Makes wait on the line and waiting till all task execution done.
            Task.WhenAll(task1, task2).Wait();
            Console.WriteLine("Execution is done");
        }
        static void TaskExecution()
        {
            Task.Delay(1000).Wait();
            Console.WriteLine("ID of task"+Task.CurrentId);
        }
    }
}
