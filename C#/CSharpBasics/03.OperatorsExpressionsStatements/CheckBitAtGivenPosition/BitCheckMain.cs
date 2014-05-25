/*Write a Boolean expression that returns if the bit at position p
 *(counting from 0, starting from the right) in given integer number n has value of 1. */

namespace CheckBitAtGivenPosition
{
    using System;

    class BitCheckMain
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var position = int.Parse(Console.ReadLine());

            if (((input >> position) & 1) == 1)
            {
                Console.WriteLine(Convert.ToString(input, 2).PadLeft(32, '0'));
                Console.WriteLine(new string(' ', 31 - position) + '\u2191');
                Console.WriteLine(new string(' ', 31 - position) + "\u2514\u2192 Has a value 1.");
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(Convert.ToString(input, 2).PadLeft(32, '0'));
                Console.WriteLine(new string(' ', 31 - position) + '\u2191');
                Console.WriteLine(new string(' ', 31 - position) + "\u2514\u2192 Has a value 0.");
                Console.WriteLine(false);
            }
        }
    }
}
