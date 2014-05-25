/*Write an expression that checks for given integer if its third digit from right-to-left is 7. */

namespace ThirdDigitSeven
{
    using System;

    class ThirdDigitMain
    {
        static void Main()
        {
            Console.WriteLine("Input an integer: ");
            var input = int.Parse(Console.ReadLine());

            //Divide the input by 100 and take the last digit as a remainder with % operator
            if ((input / 100) % 10 == 7 )
            {
                Console.WriteLine("Third digit is 7 - True");
            }
            else
            {
                Console.WriteLine("Third digit is 7 - False");
            }
        }
    }
}
