namespace CartesianCoordinateSystem
{
    using System;
    using System.Numerics;

    class CartesianCoordinateSystemMain
    {
        static void Main()
        {
            var inputX = decimal.Parse(Console.ReadLine());
            var inputY = decimal.Parse(Console.ReadLine());

            if (inputX > 0 && inputY > 0)
            {
                Console.WriteLine(1);
            }
            else if (inputX < 0 && inputY > 0)
            {
                Console.WriteLine(2);
            }
            else if (inputX < 0 && inputY < 0)
            {
                Console.WriteLine(3);
            }
            else if (inputX > 0 && inputY < 0)
            {
                Console.WriteLine(4);
            }
            else if (inputX == 0 && inputY != 0)
            {
                Console.WriteLine(5);
            }
            else if (inputX != 0 && inputY == 0)
            {
                Console.WriteLine(6);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
