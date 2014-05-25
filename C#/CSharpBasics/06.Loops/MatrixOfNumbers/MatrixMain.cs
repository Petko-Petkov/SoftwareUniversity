/*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. */

namespace MatrixOfNumbers
{
    using System;

    class MatrixMain
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var output = 1;

            for (int row = 1; row <= input; row++)
            {
                output = row;

                for (int col = 0; col < input; col++)
                {
                    Console.Write("{0,3}", output);
                    output++;
                }

                Console.WriteLine();
            }
        }
    }
}
