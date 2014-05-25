/*Write a program that enters 3 real numbers and prints them sorted in descending order. 
 * Use nested if statements. Don’t use arrays and the built-in sorting functionality. */

namespace SortThreeNumbersWithNestedIfs
{
    using System;

    class SorterMain
    {
        static void Main()
        {
            var first = decimal.Parse(Console.ReadLine());
            var second = decimal.Parse(Console.ReadLine());
            var third = decimal.Parse(Console.ReadLine());

            if (first >= second)
            {
                if (second >= third)
                {
                    Console.WriteLine(first + " " + second + " " + third);
                }
                else if (second <= third && third <= first)
                {
                    Console.WriteLine(first + " " + third + " " + second);
                }
                else
                {
                    Console.WriteLine(third + " " + first + " " + second);
                }
            }

            if (second > first)
            {
                if (first >= third)
                {
                    Console.WriteLine(second + " " + first + " " + third);
                }
                else if (second <= third)
                {
                    Console.WriteLine(third + " " + second + " " + first);
                }
                else
                {
                    Console.WriteLine(second + " " + third + " " + first);
                }
            }

        }
    }
}
