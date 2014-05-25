/*Write an expression that calculates rectangle’s perimeter and area by given width and height.*/

namespace RectanglePerimeterAndArea
{
    using System;

    class RectangleMain
    {
        static void Main()
        {
            //Taking the width and height from the user 
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            //Calculating area and perimeter
            var area = width * height;
            var perimeter = (width + height) * 2;
            
            //Write it on the console
            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Perimeter = {0}", perimeter);
        }
    }
}
