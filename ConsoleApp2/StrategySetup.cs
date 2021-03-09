
using System;

namespace ConsoleApp2
{
    public class StrategySetup
    {
        private readonly Func<OperationEnum, IStrategy> func;

        public StrategySetup(Func<OperationEnum, IStrategy> func)
        {
            this.func = func;
        }
        public int executeStreategy(int num, int num2)
        {
            return func(OperationEnum.Add).doOperation(num, num2);

        }

    }
}
