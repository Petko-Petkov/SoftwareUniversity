namespace BinaryDigitsCount
{
    using System;

    class BinaryDigitsCountMain
    {
        static void Main()
        {
            int binaryDigit = int.Parse(Console.ReadLine());
            int numbersCount = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numbersCount; i++)
            {
                long number = long.Parse(Console.ReadLine());
                int binaryCounter = 0;

                while (number != 0)
                {
                    if ((number & 1) == binaryDigit)
                    {
                        binaryCounter++;                        
                    }

                    number = number >> 1;
                }

                Console.WriteLine(binaryCounter);
            }
        }
    }
}