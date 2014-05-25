/*Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), 
 * a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. 
 * Each column should have a width of 10 characters. The number a should be printed in hexadecimal, 
 * left aligned; then the number a should be printed in binary form, padded with zeroes, then the number 
 * b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed 
 * with 3 digits after the decimal point, left aligned. */

namespace FormattingNumbers
{
    using System;

    class FormattingMain
    {
        static void Main()
        {
            bool isValid = false;
            var inputA = 0;

            while (!isValid)
            {
                Console.WriteLine("Input an integer in the range 0 - 500 : ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out inputA);
            }

            var binaryA = Convert.ToString(inputA, 2).PadLeft(10, '0');
            var inputB = float.Parse(Console.ReadLine());
            var inputC = float.Parse(Console.ReadLine());

            Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:F2}|{3, -10:#.###}|", inputA, binaryA, inputB, inputC);
        }
    }
}
