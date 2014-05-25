/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
•	Prints on the console the number in reversed order: dcba (in our example 1102).
•	Puts the last digit in the first position: dabc (in our example 1201).
•	Exchanges the second and the third digits: acbd (in our example 2101).
*/

namespace SumOfFourDigitNumber
{
    using System;

    class SumMain
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var sum = 0;
            var tempInput = input;

            //Divide by 10 with remainder and sum the remainder 
            while (tempInput != 0)
            {
                sum += tempInput % 10;
                tempInput /= 10;
            }

            Console.WriteLine("Sum of the digits in input:\n{0}", sum);
            
            tempInput = input;

            //Divide by 10 with remainder and write it on the console
            Console.WriteLine("Reversed input: ");
            while (tempInput != 0)
            {
                Console.Write(tempInput % 10);
                tempInput /= 10;
            }

            Console.WriteLine();


            //Divide by 10 with remainder and concatenate the remainder with the rest of the input
            Console.WriteLine("Reversed first and last digit:");
            Console.WriteLine((input % 10).ToString() + (input / 10).ToString());

            //Taking each digit as a variable and then write it on the console
            Console.WriteLine("Reveresed third and second digit:");
            int lastDigit = input % 10;
            input /= 10;
            int thirdDigit = input % 10;
            input /= 10;
            int secondDigit = input % 10;
            input /= 10;
            Console.Write("{0}{1}{2}{3}",input, thirdDigit, secondDigit, lastDigit);
            Console.WriteLine();
        }
    }
}
