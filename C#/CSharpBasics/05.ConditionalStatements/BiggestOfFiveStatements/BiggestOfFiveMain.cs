/*Write a program that finds the biggest of five numbers by using only five if statements. */

namespace BiggestOfFiveStatements
{
    using System;

    class BiggestOfFiveMain
    {
        static void Main()
        {
            decimal biggest = decimal.MinValue;

            for (int i = 0; i < 5; i++)
            {
                var input = decimal.Parse(Console.ReadLine());

                if (input > biggest)
                {
                    biggest = input;
                }
            }

            Console.WriteLine(biggest);
        }
    }
}
