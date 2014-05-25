/*Write a program that reads an integer number n from the console and prints all the numbers in the 
 * interval [1..n], each on a single line. Note that you may need to use a for-loop. */

namespace NumberFrom1ToN
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
                Console.WriteLine(i);
            }
        }
    }
}
