/*Write an expression that checks for given point (x, y) if it is within 
 * the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). */

namespace PointWithinCircleOutsideRectangle
{
    using System;

    class PointCheckMain
    {
        static void Main(string[] args)
        {        
            //Taking data from user
            var xCoord = double.Parse(Console.ReadLine());
            var yCoord = double.Parse(Console.ReadLine());
            
            //Calculating via Pitagor if our point is inside the circle (cheking if hypotenuse is smaller than radius 1.5)
            var hypotenuse = Math.Sqrt((Math.Pow((xCoord - 1), 2) + Math.Pow((yCoord - 1), 2)));

            //Final check if point is within the circle and outside the rectangleS
            if ((hypotenuse <= 1.5) && (yCoord > 1))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }           
        }
    }
}
