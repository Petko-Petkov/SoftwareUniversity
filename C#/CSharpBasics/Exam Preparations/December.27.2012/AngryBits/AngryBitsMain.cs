namespace AngryBits
{
    using System;
    using System.Collections.Generic;

    class AngryBitsMain
    {
        static void Main()
        {
            char[,] matrix = Helper.FillMatrix(8, 16);
            Dictionary<char, byte> obstacles = new Dictionary<char, byte>();
            obstacles.Add('1', 1);
            int currentRow = 0;
            int currentCol = 0;
            int result = 0;

            //Helper.PrintMatrix(matrix, string.Empty);

            for (int col = 7; col >= 0; col--)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (matrix[i, col] == '1')
                    {
                        matrix[i, col] = '0';
                        int flight = 1;
                        currentCol = col;
                        currentRow = i;
                        int borderCount = 0;
                        Helper.Direction direction = Helper.Direction.NE;

                        while (borderCount != 2)
                        {
                            int check = Helper.Check(obstacles, matrix, currentRow, currentCol, direction);

                            switch (check)
                            {
                                case 1:
                                    {
                                        Helper.Move(direction, ref currentRow, ref currentCol);
                                        matrix[currentRow, currentCol] = '0';
                                        result += flight * Splash(matrix, currentRow, currentCol);
                                        borderCount = 2;
                                    }
                                    break;
                                case -1:
                                    {
                                        Helper.Move(direction, ref currentRow, ref currentCol);
                                        flight++;
                                    }
                                    break;
                                case -2:
                                    {
                                        borderCount++;
                                        direction = Helper.Direction.SE;
                                    }
                                    break;
                            }
                        }
                       // Console.WriteLine("-------------------------------------");
                        //Helper.PrintMatrix(matrix, string.Empty);
                        //Console.WriteLine(result);
                        continue;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == '1')
                    {
                        Console.WriteLine("{0} No", result);
                        return;
                    }

                }
            }

            Console.WriteLine("{0} Yes", result);
        }

        private static int Splash(char[,] matrix, int currentRow, int currentCol)
        {
            var directions = Enum.GetValues(typeof(Helper.Direction));
            int pigsDead = 1;

            foreach (var direction in directions)
            {
                if (Check(matrix, currentRow, currentCol, (Helper.Direction)direction) == 1)
                {
                    pigsDead++;
                }
            }

            return pigsDead;
        }

        public static int Check(char[,] arrayMatrix, int currentRow, int currentCol, Helper.Direction direction)
        {
            try
            {
                Helper.Move(direction, ref currentRow, ref currentCol);

                if (arrayMatrix[currentRow, currentCol] == '1')
                {
                    arrayMatrix[currentRow, currentCol] = '0';
                    return 1;
                }

                return -1;
            }
            catch (Exception)
            {

                return -2;
            }
        }
    }

    public static class Helper
    {
        public static string[] FillArrayMatrix(int row, int col)
        {
            string[] result = new string[row];

            for (int i = 0; i < row; i++)
            {
                int input = int.Parse(Console.ReadLine());
                result[i] = Convert.ToString(input, 2).PadLeft(col, '0');
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

        public static void PrintMatrix(int[,] matrix, string separator)
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

        public static void PrintMatrix(char[,] matrix, string separator)
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

        public enum Direction { N = 1, NW = 2, W = 3, SW = 4, S = 5, SE = 6, E = 7, NE = 8 };

        public static void Move(Direction direction, ref int currentRow, ref int currentCol)
        {
            switch (direction)
            {
                case Direction.N:
                    {
                        currentRow--;
                    }
                    break;
                case Direction.NW:
                    {
                        currentCol--;
                        currentRow--;
                    }
                    break;
                case Direction.W:
                    {
                        currentCol--;
                    }
                    break;
                case Direction.SW:
                    {
                        currentCol--;
                        currentRow++;
                    }
                    break;
                case Direction.S:
                    {
                        currentRow++;
                    }
                    break;
                case Direction.SE:
                    {
                        currentRow++;
                        currentCol++;
                    }
                    break;
                case Direction.E:
                    {
                        currentCol++;
                    }
                    break;
                case Direction.NE:
                    {
                        currentCol++;
                        currentRow--;
                    }
                    break;
            }
        }

        public static int Check(Dictionary<char, byte> obstacles, string[] arrayMatrix, int currentRow, int currentCol, Direction direction)
        {
            try
            {
                Move(direction, ref currentRow, ref currentCol);

                foreach (var obstacle in obstacles)
                {
                    if (arrayMatrix[currentRow][currentCol] == obstacle.Key)
                    {
                        return obstacle.Value;
                    }
                }

                return -1;
            }
            catch (Exception)
            {

                return -2;
            }
        }

        public static int Check(Dictionary<char, byte> obstacles, char[,] arrayMatrix, int currentRow, int currentCol, Direction direction)
        {
            try
            {
                Move(direction, ref currentRow, ref currentCol);

                foreach (var obstacle in obstacles)
                {
                    if (arrayMatrix[currentRow, currentCol] == obstacle.Key)
                    {
                        return obstacle.Value;
                    }
                }

                return -1;
            }
            catch (Exception)
            {

                return -2;
            }
        }
    }
}

