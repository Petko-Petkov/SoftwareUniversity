/*Write a program that reads the radius r of a circle and prints its 
 * perimeter and area formatted with 2 digits after the decimal point. */

namespace CirclePerimeterAndArea
{
    using System;

    class CircleMain
    {
        static void Main()
        {
            var radius = double.Parse(Console.ReadLine());

            var perimeter = 2 * radius * Math.PI;

            var area = Math.Pow(radius, 2) * Math.PI;

            Console.WriteLine("Perimiter of a circle with radius {0} is {1: 0.00} and its area is {2: 0.00}.", radius, perimeter, area);
        }
    }
}
