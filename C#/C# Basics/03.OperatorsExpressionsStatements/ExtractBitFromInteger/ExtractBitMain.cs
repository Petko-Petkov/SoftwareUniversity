/*Write an expression that extracts from given integer n the value of given bit at index p. */
namespace ExtractBitFromInteger
{
    using System;

    class ExtractBitMain
    {
        static void Main()
        {
            //Taking input data from the user
            var input = int.Parse(Console.ReadLine());
            var position = byte.Parse(Console.ReadLine());

            if ((input >> position & 1) == 1)
            {                
                Console.WriteLine(Convert.ToString(input, 2).PadLeft(32, '0'));
                Console.WriteLine(new string(' ', 31 - position) + '\u2191');
                Console.WriteLine(new string(' ', 31 - position) + "\u2514\u2192 Has a value 1.");
                Console.WriteLine("Bit at position p is 1");
            }
            else
            {
                Console.WriteLine(Convert.ToString(input, 2).PadLeft(32, '0'));
                Console.WriteLine(new string(' ', 31 - position) + '\u2191');
                Console.WriteLine(new string(' ', 31 - position) + "\u2514\u2192 Has a value 0.");
                Console.WriteLine("Bit at position p is 0");
            }
        }
    }
}
