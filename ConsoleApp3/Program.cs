using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  public   class Program
    {
        static void Main(string[] args)
        {

            IShape shp = ShapeFactory.CreateShape(Shape.Circle);

            shp.draw();

            Console.ReadLine(  );
        }
    }
}
