using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(Shape shape) {

            switch (shape)
            {
                case Shape.Rectagnle:
                    return new Rectagnle();
                case Shape.Circle:
                    return new circle();
                default:
                    break;
            }

            return null;
        }
    
    
    }
}
public enum Shape {
    Rectagnle,
    Circle
}