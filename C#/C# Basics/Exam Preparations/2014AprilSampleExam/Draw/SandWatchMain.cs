namespace Draw
{
    using System;

    class SandWatchMain
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input / 2 + 1; i++)
            {
                Console.Write(new string('.', i));

                for (int j = input - 2*i; j == input - 2*i; j-= 2)
                {
                    Console.Write(new string('*', j));
                }

                Console.Write(new string('.', i));

                Console.WriteLine();
            }

            int middle = 3;

            for (int i = input / 2 - 1; i >= 0; i--)
            {
                Console.Write(new string('.', i));

                for (int j = 0; j < middle; j ++)
                {
                    Console.Write('*');
                }
                middle += 2;

                Console.Write(new string ('.', i));

                Console.WriteLine();
            }
        }
    }
}
