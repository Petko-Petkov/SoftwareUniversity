/*Write a program that shows the sign (+, - or 0) of the product of three real 
 * numbers, without calculating it. Use a sequence of if operators. */

namespace MultiplicationSign
{
    using System;

    class MultiplicationSignMain
    {
        static void Main()
        {
            Console.WriteLine("Input three real numbers: ");

            var positive = "+";

            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                var sign = double.Parse(input);

                if (sign == 0)
                {
                    Console.WriteLine("0");
                    return;
                }

                if (sign < 0 && positive == "+")
                {
                    positive = "-";
                }
                else if (sign < 0 && positive == "-")
                {
                    positive = "+";
                }
            }

            Console.WriteLine("The sign of them after calculations is {0}", positive);
        }
    }
}
