/*Using loops write a program that converts a binary integer number to its decimal form. 
 * The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. */

namespace BinaryToDecimal
{
    using System;
    using System.Linq;

    class BinaryConvertorMain
    {
        static void Main()
        {
            Console.WriteLine("Input binary number : ");
            string binary = Console.ReadLine();
            int[] array = new int[binary.Length];
            long sum = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                array[binary.Length - i - 1] = int.Parse(binary[i].ToString());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    sum += 0;
                }
                else
                {
                    sum += (int)Math.Pow(2, i);
                }                
            }

            Console.WriteLine(sum);
        }
    }
}
