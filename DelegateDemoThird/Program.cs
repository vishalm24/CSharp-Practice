namespace DelegateDemoThird
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations operate = new Operations();
            Processor processor = new Processor();
            Division division = new Division();
            Action<int, int> operationHandler = operate.Addition;
            operationHandler += operate.Substraction;
            operationHandler += operate.Multiplication;
            operationHandler += division.Divide;
            processor.Process(4, 6, operationHandler);
        }

        //Normal way of delegate:
        //static void Main(string[] args)
        //{
        //    Operations operate = new Operations();
        //    Processor processor = new Processor();
        //    Division division = new Division();
        //    Processor.OperationHandler operationHandler = operate.Addition;
        //    operationHandler += operate.Substraction;
        //    operationHandler += operate.Multiplication;
        //    operationHandler += division.Divide;
        //    processor.Process(4, 6, operationHandler);
        //}
    }
}
