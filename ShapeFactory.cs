using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class ShapeFactory
    {
        public static IShape GetShape(string shapeType)
        {
            switch (shapeType.ToLower())
            {
                case "circle":
                    return new Circle();
                case "traingle":
                    return new Traingle();
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }
}
