/*We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
 * Write a sequence of operators (a few lines of C# code) that modifies n to hold 
 * the value v at the position p from the binary representation of n while preserving all other bits in n. */

namespace ModifyBitAtPosition
{
    using System;

    class BitModifierMain
    {
        static void Main()
        {
            //Taking data from user
            Console.WriteLine("Input an integer: ");
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine("Input bit value e.g. 0 or 1");
            var bitValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a position lower than 31");
            var position = int.Parse(Console.ReadLine());

            //Calculating result
            var result = (bitValue == 0 ? input & (~(1 << position)) : input | (1 << position));

            Console.WriteLine(result);
        }
    }
}
