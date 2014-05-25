/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
 * the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
 * The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. */

namespace MinMaxSumAverage
{
    using System;

    class CalculationsMain
    {
        static void Main()
        {
            Console.WriteLine("Input an integer: ");

            var input = int.Parse(Console.ReadLine());
            var sum = 0m;
            var count = 0;
            var average = 0m;
            var maxValue = long.MinValue;
            var minValue = long.MaxValue;

            for (int i = 1; i <= input; i++)
            {
                count++;

                var number = long.Parse(Console.ReadLine());

                if (number > maxValue)
                {
                    maxValue = number;
                }

                if (number < minValue)
                {
                    minValue = number;
                }

                sum += number;

                average = sum / count;
            }

            Console.WriteLine("Min = {0}", minValue);
            Console.WriteLine("Max = {0}", maxValue);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", average);
        }
    }
}
