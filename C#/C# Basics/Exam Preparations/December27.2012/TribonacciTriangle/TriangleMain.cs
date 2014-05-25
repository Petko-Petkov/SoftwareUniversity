namespace TribonacciTriangle
{
    using System;

    class TriangleMain
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            int temp;

            Console.WriteLine(first);
            Console.WriteLine(second + " " + third);

            int cw = 0;

            for (int i = 3; i <= lines; i++)
            {
                while (i > cw)
                {
                    temp = first + second + third;
                    first = second;
                    second = third;
                    third = temp;

                    Console.Write(temp + " ");
                    cw++;
                }
                Console.WriteLine();

                cw = 0;
            }
        }
    }
}
