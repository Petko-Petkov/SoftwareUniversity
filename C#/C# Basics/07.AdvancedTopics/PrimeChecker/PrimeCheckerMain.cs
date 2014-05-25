/*Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. */

namespace PrimeChecker
{
    using System;

    class PrimeCheckerMain
    {
        static void Main()
        {
            Console.WriteLine("Input an integer: ");
            var input = long.Parse(Console.ReadLine());
            Console.WriteLine("{0} is prime - {1}", input, PrimeCheck(input));
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
