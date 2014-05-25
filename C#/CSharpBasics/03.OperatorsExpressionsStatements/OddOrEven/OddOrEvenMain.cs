/*Write an expression that checks if given integer is odd or even. */

namespace OddOrEven
{
    using System;

    class OddOrEvenMain
    {
        static void Main()
        {
            //Taking an in integer from the user
            Console.WriteLine("Input an integer: ");
            int input = int.Parse(Console.ReadLine());

            //Here bitwise I check the last bit and if it is 1 the number is odd, otherwise it is even
            if ((input & 1) == 1)
            {
                Console.WriteLine("The integer is odd.");
            }
            else
            {
                Console.WriteLine("The niteger is even.");
            }
        }
    }
}
