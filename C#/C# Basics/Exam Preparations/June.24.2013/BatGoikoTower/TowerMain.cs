namespace BatGoikoTower
{
    using System;

    class TowerMain
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int dotsCount = input - 1;
            int dashLine = 1;
            int incrementer = 1;
            string[] matrix = new string[input];

            for (int i = 0; i < input; i++)
            {
                if (i == dashLine)
                {
                    matrix[i] = string.Format("{0}{1}{2}{3}{0}", new string('.', dotsCount), '/', new string('-', dashLine * 2), '\\');
                    incrementer++;
                    dashLine += incrementer;
                }
                else
                {
                    matrix[i] = string.Format("{0}{1}{2}{3}{0}", new string('.', dotsCount), '/', new string('.', i*2), '\\');
                }

                dotsCount--;
            }

            PrintArrayMatrix(matrix, string.Empty);
        }
        public static void PrintArrayMatrix(string[] array, string separator)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]);

                    if (j != array[i].Length - 1)
                    {
                        Console.Write(separator);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
