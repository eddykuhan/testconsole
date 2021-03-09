namespace ConsoleApp2
{
    public class OperationMultiply : IStrategy
    {
        public int doOperation(int num, int num2)
        {
            return num * num2;
        }
    }
}
