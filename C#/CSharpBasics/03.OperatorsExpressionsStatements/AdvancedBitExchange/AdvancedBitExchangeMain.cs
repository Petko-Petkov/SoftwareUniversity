/*Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1}
 * of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap.*/

namespace BitsExchange
{
    using System;

    class BitsExchangeMain
    {
        //Method for setting a bit at given position
        static int SetBits(int inputNumber, int position, int bitValue)
        {
            return bitValue == 0 ? inputNumber & (~(1 << position)) : inputNumber | (1 << position);
        }

        //Method for taking a bit at given position
        static int BitValue(int inputNumber, int position)
        {
            return (((1 << position) & inputNumber) >> position);
        }

        static void Main()
        {
            //Taking input data from user
            Console.WriteLine("Input an integer.");
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(input, 2).PadLeft(32, '0'));
            Console.WriteLine("Input value p: ");
            var p = int.Parse(Console.ReadLine());
            Console.WriteLine("Input value q: ");
            var q = int.Parse(Console.ReadLine());
            Console.WriteLine("Input value k: ");
            var k = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Check for overlapping
            if (p + k > q)
            {
                Console.WriteLine("Overlapping!");
            }

            //Calculating the result
            for (int i = 0; i < k; i++)
            {
                var smallerBit = BitValue(input, p + i);
                var higherBit = BitValue(input, q + i);
                input = SetBits(input, p + i, higherBit);
                input = SetBits(input, q + i, smallerBit);
            }

            Console.WriteLine("Result after exchange is:\n{0}\n{1}", input, Convert.ToString(input, 2).PadLeft(32, '0'));
        }
    }
}
