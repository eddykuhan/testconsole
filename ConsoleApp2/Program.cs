using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //class behaviour changes at runtime 

            var str = new StrategySetup(GetStrategy);
            Console.WriteLine(str.executeStreategy(1, 2));

            Console.ReadLine();
        }
        private static Func<OperationEnum, IStrategy> GetStrategy = key =>
        {
            {

                switch (key)
                {
                    case OperationEnum.Add:
                        return new OperationAdd();
                    case OperationEnum.Multiply:
                        return new OperationMultiply();
                    default:
                        break;

                }
                return null;
            }
        };

    }

}

public enum OperationEnum
{
    Add,
    Multiply
}

