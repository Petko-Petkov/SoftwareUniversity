/*Write an expression that calculates trapezoid's area by given sides a and b and height h. */

namespace TrapezoidArea
{
    using System;

    class TrapezoidMain
    {
        static void Main()
        {
            //Taking input data from the user
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            //Calculating and printing the area
            Console.WriteLine("Area of trapezoid with a = {0}, b = {1}, h = {2} is: {3}", sideA, sideB, height, ((sideA + sideB) / 2) * height);
        }
    }
}
