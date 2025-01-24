namespace DelegateDemoFourth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //By using Func<>
            Operations operation = new Operations();
            Processor processor = new Processor();
            Func<int, int, int> operationHandler = operation.Addition;
            Console.WriteLine("4 + 6 = " + processor.Process(4,6, operationHandler));
            operationHandler = operation.Substraction;
            Console.WriteLine("4 - 6 = " + processor.Process(4, 6, operationHandler));
            operationHandler = operation.Multiplication;
            Console.WriteLine("4 * 6 = " + processor.Process(4, 6, operationHandler));
            operationHandler = operation.Division;
            Console.WriteLine("4 / 6 = " + processor.Process(4, 6, operationHandler));

            ////Normal way to do delegate
            //List<int> output = new List<int>();
            //Operations operation = new Operations();
            //Processor processor = new Processor();
            //Processor.OperationHandler operationHandler = operation.Addition;
            //operationHandler += operation.Substraction;
            //operationHandler += operation.Multiplication;
            //operationHandler += operation.Division;
            //processor.Process(4, 6, ref output, operationHandler);
            //Console.WriteLine("4 + 6 = " + output[0]);
            //Console.WriteLine("4 - 6 = " + output[1]);
            //Console.WriteLine("4 * 6 = " + output[2]);
            //Console.WriteLine("4 / 6 = " + output[3]);
        }
    }
}
