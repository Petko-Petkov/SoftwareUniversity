/*Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. */

namespace FactorialCalculations
{
    using System;
    using System.Numerics;

    class FactorialDivisionMain
    {
        static void Main()
        {
            Console.WriteLine("Input an integer n - greater than 0 and smaller than 100 : ");

            var n = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine("Input an integer k - greater than 0 and smaller than n : ");

            var k = int.Parse(Console.ReadLine());

            for (int i = (int)n - 1; i > k; i--)
            {
                n *= i;
            }

            Console.WriteLine("Result of n! divided by k! is : {0}", n);
        }
    }
}
