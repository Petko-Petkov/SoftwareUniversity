/*In combinatorics, the Catalan numbers are calculated by the following formula:
  
Write a program to calculate the nth Catalan number by given n (1 < n < 100). */

using System;
using System.Numerics;

class CatalanFormula
{
    static BigInteger Factorial(int factor)
    {
        BigInteger result = 1;
        for (int i = 1; i <= factor; i++)
        {
            result = result * i;
        }
        return result;
    }

    static BigInteger DivideFactorials(int factorial1, int factorial2)
    {
        BigInteger result = 1;
        for (int i = factorial2 + 1; i <= factorial1; i++)
        {
            result = result * i;
        }
        return result;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger result = DivideFactorials((2 * n), (n + 1)) / Factorial(n);
        Console.WriteLine(result);
    }
}