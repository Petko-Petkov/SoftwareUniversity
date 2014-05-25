/*Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
 * Use only one loop. Print the result with 5 digits after the decimal point.*/

namespace FactorialPowCalculations
{
    using System;

    class CalculationsMain
    {
        static void Main()
        {
            double sum = 1;
            var inputN = double.Parse(Console.ReadLine());
            var inputX = double.Parse(Console.ReadLine());
            double factorial = 1;
            double powed = inputX;

            for (int i = 1; i <= inputN; i++)
            {
                factorial *= i;                
                sum += factorial / powed;
                powed *= inputX;
            }

            Console.WriteLine(sum);
        }
    }
}
