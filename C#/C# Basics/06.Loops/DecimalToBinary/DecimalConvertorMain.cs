/*Using loops write a program that converts an integer number to its binary representation. 
 * The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. */

namespace DecimalToBinary
{
    using System;

    class DecimalConvertorMain
    {
        static void Main()
        {
            Console.WriteLine("Input an integer smaller than {0} : ", long.MaxValue);
            var input = long.Parse(Console.ReadLine());
            string result = string.Empty;

            while (input > 0)
            {
                string tmpStr = (input & 1).ToString();
                result = tmpStr + result;
                input >>= 1;
            }

            Console.WriteLine(result);
        }
    }
}
