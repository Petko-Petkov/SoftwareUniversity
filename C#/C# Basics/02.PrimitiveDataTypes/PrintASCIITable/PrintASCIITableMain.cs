/*Find online more information about ASCII (American Standard Code for Information Interchange) 
 * and write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255).
 * Note that some characters have a special purpose and will not be displayed as expected. You may skip them or 
 * display them differently. You may need to use for-loops (learn in Internet how).*/

namespace PrintASCIITable
{
    using System;
    using System.Text;

    class PrintASCIITableMain
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char character = '\u0000';
            int number = 0;

            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine("[{0, -1}] = {1}", number, character);
                character++;
                number++;
            }
        }
    }
}
