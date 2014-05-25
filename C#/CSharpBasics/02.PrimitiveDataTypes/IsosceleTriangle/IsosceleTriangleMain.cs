/*Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©
  © ©
 ©   ©
© © © ©
Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character 
 * encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © 
 * symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.*/

namespace IsosceleTriangle
{
    using System;
    using System.Text;

    class IsosceleTriangleMain
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            char copyRight = '\u00a9';
            int input = 4;
            int spaces = 1;


            for (int i = 1; i <= input; i++)
            {
                Console.Write(new string(' ', input - i));

                for (int j = 1; j <= i; j++)
                {     
                    //TODO: To Fix the inner characters
                    if (i == 1 || i == input)
                    {
                        Console.Write(copyRight);
                        Console.Write(new string(' ', 1));
                    }
                    else
                    {
                        Console.Write(copyRight);
                        Console.Write(new string(' ', spaces));
                        Console.Write(copyRight);
                        spaces += 2;
                        break;
                    }
                    
                }

                Console.WriteLine();
            }
        }
    }
}
