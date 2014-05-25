namespace Sheets
{
    using System;

    class SheetsMain
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            int counter = 10;

            for (int i = 0; i < 11; i++)
            {
                if ((input & 1) == 0)
                {
                    Console.WriteLine("A{0}", counter);
                }

                input >>= 1;
                counter--;
            }
        }
    }
}
