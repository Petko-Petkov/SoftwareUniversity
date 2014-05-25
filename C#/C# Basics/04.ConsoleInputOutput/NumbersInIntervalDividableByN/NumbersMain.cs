/*Write a program that reads two positive integer numbers and prints how many 
 * numbers p exist between them such that the reminder of the division by 5 is 0. */

namespace NumbersInIntervalDividableByN
{
    using System;

    class NumbersMain
    {
        static void Main()
        {
            Console.WriteLine("Input numbers for start and end of a sequence: ");

            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());

            //Console.WriteLine("Input a divider: ");

            var divider = 5;
            var counter = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % divider == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
