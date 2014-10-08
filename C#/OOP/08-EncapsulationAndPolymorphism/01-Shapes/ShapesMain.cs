namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ShapesMain
    {
        public static void Main()
        {
            var shapes = new List<IShape>()
                             {
                                 new Circle(2.56),
                                 new Rectangle(4.5, 3),
                                 new Triangle(4, 2, 30),
                                 new Rectangle(5, 6),
                                 new Circle(3.5),
                                 new Triangle(3, 2, 40)
                             };

            var sortedShapesByArea = shapes.OrderBy(s => s.CalculateArea());

            foreach (var shape in sortedShapesByArea)
            {
                Console.WriteLine(shape.CalculateArea());
            }

            Console.WriteLine("\r\n");

            var sortedShapesByPerimeter = from shape in shapes
                                          orderby shape.CalculatePerimeter()
                                          select shape;

            foreach (var shape in sortedShapesByPerimeter)
            {
                Console.WriteLine(shape.CalculatePerimeter());
            }
        }
    }
}
