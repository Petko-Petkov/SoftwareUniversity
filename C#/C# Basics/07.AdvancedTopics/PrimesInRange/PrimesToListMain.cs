/*Write a method that calculates all prime numbers in given range and returns them as list of integers:
static List<int> FindPrimesInRange(startNum, endNum)
{
    …
}
Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.
*/

namespace PrimesInRange
{
    using System;
    using System.Collections.Generic;
    using PrimeChecker;

    class PrimesToListMain
    {
        static void Main()
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            PrimeToList(start, end);
            PrintList(PrimeToList(start, end));
        }

        private static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);

                if (i != list.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }

        private static List<int> PrimeToList(int start, int end)
        {
            List<int> primeList = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (PrimeCheck(i))
                {
                    primeList.Add(i);
                }
            }

            return primeList;
        }

        public static bool PrimeCheck(long number)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
