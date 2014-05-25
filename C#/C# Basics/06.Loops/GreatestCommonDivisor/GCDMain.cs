/*Write a program that calculates the greatest common divisor (GCD)
 * of given two integers a and b. Use the Euclidean algorithm (find it in Internet). */

namespace GreatestCommonDivisor
{
    using System;

    class GCDMain
    {
        static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(GCD(a, b)));
        }
    }
}
