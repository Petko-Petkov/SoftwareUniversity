/*Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
 * (i.e. it is divisible without remainder only to itself and 1). */

namespace PrimeNumbersCheck
{
    using System;

    class PrimeNumbersMain
    {
        static void Main()
        {
            //Taking an integer from the user
            var input = int.Parse(Console.ReadLine());
            bool isPrime = true;

            //Cheking for each ot its divisors if it is divided with remainder
            for (int i = 2; i < 10; i++)
            {
                if ((input % i) == 0)
                {
                    isPrime = false;
                }
            }

            Console.WriteLine(isPrime);
        }
    }
}
