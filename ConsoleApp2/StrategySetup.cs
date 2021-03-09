namespace ConsoleApp2
{
    public class StrategySetup
    {
        private IStrategy strategy;
        public StrategySetup(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int executeStreategy(int num, int num2)
        {

            return strategy.doOperation(num, num2);

        }
    }
}
