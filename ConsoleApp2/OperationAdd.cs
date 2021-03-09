using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class OperationAdd : IStrategy
    {
        public int doOperation(int num, int num2)
        {
            return num + num2;
        }
    }
}
