/*Write a program that reads a number n and prints on the console the first n members 
 * of the Fibonacci sequence (at a single line, separated by spaces) : 
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. */

namespace FibonacciNumbers
{
    using System;

    class FibonacciMain
    {
        static void Main()
        {
            Console.WriteLine("Input an integer: ");

            var input = int.Parse(Console.ReadLine());
            var first = 0;
            var second = 1;
            Console.WriteLine(first);

            for (int i = 1; i < input; i++)
            {
                var third = first + second;
                first = second;
                second = third;
                third = first;

                Console.WriteLine(third);
            }
        }
    }
}
