namespace Fire
{
    using System;

    class TorchMain
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int limit = (input / 4) * 3;
            string[] upperMatrix = new string[limit];
            string border = new string('-', input);
            string[] lowerMatrix = new string[input / 2];
            int count = 0;

            for (int i = 0; i < input / 2; i++)
            {
                upperMatrix[i] = string.Format("{0}{1}{2}{1}{0}", new string('.', (input/2 - 1) -i), '#', new string('.', count));
                count += 2;
            }

            count = input - 2;

            for (int i = 0; i < input / 4; i++)
            {
                upperMatrix[input/2 + i] = string.Format("{0}{1}{2}{1}{0}", new string('.', i), '#', new string('.', count));
                count -= 2;
            }

            PrintArrayMatrix(upperMatrix, string.Empty);

            Console.WriteLine(border);

            for (int i = 0; i < input / 2; i++)
            {
                lowerMatrix[i] = string.Format("{0}{1}{2}{0}", new string('.', i), new string('\\', (input / 2) - i), new string('/', (input / 2) - i));
            }

            PrintArrayMatrix(lowerMatrix, string.Empty);
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

        public static char[,] FillMatrix(int row, int col)
        {
            string[] arrayMatrix = FillArrayMatrix(row, col);
            char[,] charMatrix = new char[row, col];

            for (int currentRow = 0; currentRow < row; currentRow++)
            {
                for (int currentCol = 0; currentCol < col; currentCol++)
                {
                    charMatrix[currentRow, currentCol] = arrayMatrix[currentRow][currentCol];
                }
            }

            return charMatrix;
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

        public static void PrintMatrix(int[,] matrix, string separator = "")
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);

                    if (j != matrix.GetLength(1) - 1)
                    {
                        Console.Write(separator);
                    }
                }

                Console.WriteLine();
            }
        }

        public static void PrintMatrix(char[,] matrix, string separator = "")
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);

                    if (j != matrix.GetLength(1) - 1)
                    {
                        Console.Write(separator);
                    }
                }

                Console.WriteLine();
            }
        }       
    }
}
