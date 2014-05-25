namespace Eggcelent
{
    using System;

    class EggcelentMain
    {
        static void Main()
        {
            //read input
            int input = int.Parse(Console.ReadLine());
            int height = 2 * input;
            int width = 3 * input + 1;
            string[] matrix = new string[width];

            //fill matrix
            for (int row = 0; row < height; row++)
            {
                matrix[row] = string.Format("{}{}{}");
            }

            //printing
            PrintArrayMatrix(matrix, string.Empty);
        }

        public static string[] FillArrayMatrix(int row, int col)
        {
            string[] result = new string[row];

            for (int i = 0; i < row; i++)
            {
                int input = int.Parse(Console.ReadLine());
                result[i] = Convert.ToString(input, 2).PadLeft(col);
            }

            return result;
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
