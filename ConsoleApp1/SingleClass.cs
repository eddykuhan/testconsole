using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SingleClass
    {
        private static SingleClass sg = new SingleClass();
        private SingleClass()
        {

        }

        public static SingleClass GetInstance() {
            return sg;
        }

        public void showMsg() {
            Console.WriteLine("Hellow");
        }
}
}
