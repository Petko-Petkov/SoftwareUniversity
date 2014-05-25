namespace SandWatch
{
    using System;

    class SandGlassMain
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            int dotsCount = 0;
            int asteriksCount = input;
            int dotsCount1 = input / 2 - 1;

            for (int i = 0; i < input / 2 + 1; i++)
            {
                dotsCount = i;
                string dots = new string('.', dotsCount);
                string asteriks = new string('*', asteriksCount);
                Console.Write(dots);
                Console.Write(asteriks);
                Console.Write(dots);
                Console.WriteLine();

                asteriksCount -= 2;
            }

            for (int i = 3; i <= input; i += 2)
            {
                string dots = new string('.', dotsCount1);
                string asteriks = new string('*', i);
                Console.Write(dots);
                Console.Write(asteriks);
                Console.Write(dots);
                Console.WriteLine();
                dotsCount1--;
            }
        }
    }
}
