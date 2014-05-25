/*Create a console application that calculates and prints the square root
 * of the number 12345. Find in Internet “how to calculate square root in C#”.*/

namespace FindSquareRoot
{
    using System;

    class SquareRootMain
    {
        static void Main()
        {
            double number = 12345;
            
            double numberSqrt = Math.Sqrt(number);

            Console.WriteLine(numberSqrt);
        }
    }
}
