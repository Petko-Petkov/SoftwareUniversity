/*Using bitwise operators, write an expression for finding the value of the bit #3 
 * of a given unsigned integer. The bits are counted from right to left, starting 
 * from bit #0. The result of the expression should be either 1 or 0. */

namespace BitAtPositionThree
{
    using System;

    class ThitdBitMain
    {
        static void Main()
        {
            //Taking an integer from the user
            var input = int.Parse(Console.ReadLine());

            //Shifting the third bit to 0 position and checking if it is 1 or 0
            if (((input >> 3) & 1) == 1)
            {
                Console.WriteLine(Convert.ToString(input, 2).PadLeft(32, '0'));
                Console.WriteLine(new string(' ', 31 - 3) + '\u2191');
                Console.WriteLine(new string(' ', 31 - 3) + "\u2514\u2192 Has a value 1.");
                Console.WriteLine("Bit at position 3 is 1.");
            }
            else
            {
                Console.WriteLine(Convert.ToString(input, 2).PadLeft(32, '0'));
                Console.WriteLine(new string(' ', 31 - 3) + '\u2191');
                Console.WriteLine(new string(' ', 31 - 3) + "\u2514\u2192 Has a value 0.");
                Console.WriteLine("Bit at position 3 is 0.");
            }
        }
    }
}
