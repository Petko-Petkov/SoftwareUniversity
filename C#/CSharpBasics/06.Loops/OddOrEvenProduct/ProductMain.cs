/*You are given n integers (given in a single line, separated by a space). Write a program that checks
 * whether the product of the odd elements is equal to the product of the even elements. 
 * Elements are counted from 1 to n, so the first element is odd, the second is even, etc. */

namespace OddOrEvenProduct
{
    using System;

    class ProductMain
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int oddSum = 1;
            int evenSum = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    evenSum *= int.Parse(input[i]);
                }
                else
                {
                    oddSum *= int.Parse(input[i]);
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", oddSum);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", oddSum);
                Console.WriteLine("even_product = {0}", evenSum);
            }
        }
    }
}
