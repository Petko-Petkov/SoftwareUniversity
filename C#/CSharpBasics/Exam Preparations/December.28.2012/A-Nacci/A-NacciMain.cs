namespace A_Nacci
{
    using System;

    class Program
    {
        static void Main()
        {
            int inputA = char.Parse(Console.ReadLine());
            int inputB = char.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            int a = inputA - 64;
            int b = inputB - 64;
            int temp = a + b;

            if (temp > 26)
            {
                temp %= 26;
            }

            if (lines == 1)
            {
                Console.WriteLine((char)inputA);
                return;
            }

            Console.WriteLine((char)inputA);
            Console.Write((char)inputB);
            Console.Write((char)(temp + 64));
            Console.WriteLine();
            temp = a + b;
            if (temp > 26)
            {
                temp = temp % 26;
            }
            a = b;
            b = temp;
            temp = a;

            int counter = 0;
            int shit = 0;

            temp = a + b;
            if (temp > 26)
            {
                temp = temp % 26;
            }
            a = b;
            b = temp;
            temp = a;

            if (temp > 26)
            {
                temp = temp % 26;
            }

            for (int i = 2; i < lines; i++)
            {
                counter = i - 1;
                             
                while (shit < 2)
                {
                    temp = a + b;
                    if (temp > 26)
                    {
                        temp = temp % 26;
                    }
                    a = b;
                    b = temp;
                    temp = a;

                    if (temp > 26)
                    {
                        temp = temp % 26;
                    }


                    Console.Write((char)(temp + 64));
                    Console.Write(new string(' ', counter));
                    shit++;
                }

                shit = 0;
                Console.WriteLine();
            }
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_nacci
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    char firstLetter = Console.ReadLine()[0];
                    char secondLetter = Console.ReadLine()[0];

                    int rowsToGenerate = int.Parse(Console.ReadLine());

                    int firstCode = (firstLetter - 'A') + 1;
                    int secondCode = (secondLetter - 'A') + 1;

                    int maxCode = 'Z' - 'A' + 1;

                    Console.WriteLine(firstLetter);

                    if (rowsToGenerate >= 2)
                    {
                        Console.Write(secondLetter);

                        int currentCode = firstCode + secondCode;
                        if (currentCode > maxCode)
                        {
                            currentCode = currentCode - maxCode;
                        }

                        firstCode = secondCode;
                        secondCode = currentCode;

                        char currentLetter = (char)(currentCode + 'A' - 1);

                        Console.WriteLine(currentLetter);
                    }

                    for (int row = 3; row <= rowsToGenerate; row++)
                    {
                        int currentCode = firstCode + secondCode;
                        if (currentCode > maxCode)
                        {
                            currentCode = currentCode - maxCode;
                        }

                        firstCode = secondCode;
                        secondCode = currentCode;

                        char currentLetter = (char)(currentCode + 'A' - 1);

                        Console.Write(currentLetter);

                        for (int col = 2; col < row; col++)
                        {
                            Console.Write(" ");
                        }

                        currentCode = firstCode + secondCode;
                        if (currentCode > maxCode)
                        {
                            currentCode = currentCode - maxCode;
                        }

                        firstCode = secondCode;
                        secondCode = currentCode;

                        currentLetter = (char)(currentCode + 'A' - 1);

                        Console.Write(currentLetter);

                        Console.WriteLine();
                    }
                }
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("arithmetic error or general error");
            }
        }
    }
}*/
