using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
 public   class Program
    {
        static void Main(string[] args)
        {
            //class behaviour changes at runtime 
            var str = new StrategySetup(new OperationAdd());

            Console.WriteLine(str.executeStreategy(1, 2));
            Console.ReadLine();
        }
    }
}
