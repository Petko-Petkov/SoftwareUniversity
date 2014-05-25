/*Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).*/

namespace PointInCircle
{
    using System;

    class PointInCircleMain
    {
        static void Main()
        {
            //Taking coordinates of from the user
            Console.WriteLine("Enter coordinates X and Y of the point: ");
            var coorX = double.Parse(Console.ReadLine());
            var coorY = double.Parse(Console.ReadLine());

            //Finding the distance between (0, 0) and the point dimension via Pitagor 
            var hypotenuse = Math.Pow(coorX, 2) + Math.Pow(coorY, 2);

            //Cheking if the distance is smaller than the radius
            if (Math.Sqrt(hypotenuse) < 2)
            {
                Console.WriteLine("Point is in the circle.");
            }
            else
            {
                Console.WriteLine("Point is outside the circle.");
            }
        }
    }
}
