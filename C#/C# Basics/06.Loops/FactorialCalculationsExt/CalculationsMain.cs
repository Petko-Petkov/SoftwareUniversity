/*In combinatorics, the number of ways to choose k different members out of a group of n different elements 
 * (also known as the number of combinations) is calculated by the following formula: 
For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
 * Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops. */

namespace FactorialCalculationsExt
{
    using System;
    using System.Numerics;

    class CalculationsMain
    {
        static void Main()
        {
            bool checkInput = false;
            BigInteger inputN = 0;
            BigInteger inputK = 0;

            #region Check Input
            while (!checkInput)
            {
                Console.WriteLine("Input an integer in the range 0 - 100: ");
                checkInput = BigInteger.TryParse(Console.ReadLine(), out inputN);

                if (inputN > 0 && inputN < 100)
                {
                    checkInput = true;
                }
                else
                {
                    checkInput = false;
                }
            }

            checkInput = false;

            while (!checkInput)
            {
                Console.WriteLine("Input an integer in the range 0 - {0}", inputN);
                checkInput = BigInteger.TryParse(Console.ReadLine(), out inputK);

                if (inputK > 0 && inputK < inputN)
                {
                    checkInput = true;
                }
                else
                {
                    checkInput = false;
                }
            }
            #endregion
            
            BigInteger divisor = inputN;
            BigInteger diff = inputN - inputK;

            for (BigInteger i = inputN - 1; i > 0; i--)
            {
                inputN *= i;
                
                if (i < inputK)
                {
                    inputK *= i;
                }

                if (i < diff)
                {
                    diff *= i;
                }
            }

            Console.WriteLine(inputN / (inputK * (diff)));
        }
    }
}
