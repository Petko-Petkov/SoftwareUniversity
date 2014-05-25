/*Write a program that enters a number n and after that enters more n numbers and calculates 
 * and prints their sum. Note that you may need to use a for-loop. */

namespace SumOfNumbers
{
    using System;

    class SumMain
    {
        static void Main()
        {
            Console.WriteLine("Input an integer.");

            var input = int.Parse(Console.ReadLine());
            var sum = 0.0;

            for (int i = 0; i < input; i++)
            {
                var number = double.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine("The sum is : {0}", sum);
        }
    }
}
