/*Write a program that reads 3 integer numbers from the console and prints their sum. */

namespace SumOfThreeIntegers
{
    using System;

    class SumMain
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var sum = a + b + c;

            Console.WriteLine(sum);
        }
    }
}
