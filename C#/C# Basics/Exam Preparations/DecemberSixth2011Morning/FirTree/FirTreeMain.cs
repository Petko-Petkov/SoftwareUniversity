namespace FirTree
{
    using System;

    class FirTreeMain
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            DrawFirTree(input);
        }

        private static void DrawFirTree(int input)
        {
            int dotsCount = input - 2;
            int asterixesCount = 1;
            
            for (int i = 0; i < input - 1; i++)
            {
                string dots = new string('.', dotsCount);
                string asterixes = new string('*', asterixesCount);
                Console.Write(dots);
                Console.Write(asterixes);
                Console.Write(dots);

                dotsCount--;
                asterixesCount += 2;
                Console.WriteLine();
            }

            Console.Write(new string('.', input - 2));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', input - 2));
            Console.WriteLine();
        }
    }
}