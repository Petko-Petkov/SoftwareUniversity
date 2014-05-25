/*Write a program that enters from the console a positive integer n and 
 * prints all the numbers from 1 to n, on a single line, separated by a space. */

namespace NumbersFromOneToN
{
    using System;

    class NumbersMain
    {
        static void Main()
        {
            Console.WriteLine("Input an integer: ");

            var input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
