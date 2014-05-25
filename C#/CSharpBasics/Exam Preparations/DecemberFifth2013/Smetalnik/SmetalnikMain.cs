namespace Smetalnik
{
    using System;

    class SmetalnikMain
    {
        static void Main()
        {
            //reading input
            int width = int.Parse(Console.ReadLine());
            string[] matrix = new string[8];
            ulong sum = 0;
            int count = 0;

            for (int i = 0; i < 8; i++)
            {
                long number = long.Parse(Console.ReadLine());

                matrix[i] = Convert.ToString(number, 2).PadLeft(width, '0');
            }

            //solution
            while (true)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "reset":
                        {
                            for (int row = 0; row < 8; row++)
                            {
                                matrix[row] = PullZeroesLeft(matrix, row, width);
                            }
                        }
                        break;
                    case "left":
                        {
                            int rowDemanded = int.Parse(Console.ReadLine());
                            int colDemanded = int.Parse(Console.ReadLine());
                            if (colDemanded < 0)
                            {
                                colDemanded = 0;
                            }
                            if (colDemanded > width)
                            {
                                colDemanded = width - 1;
                            }
                            matrix[rowDemanded] = PullZeroesLeft(matrix, rowDemanded, colDemanded);
                            //PrintMatrix(matrix, 8, width);
                        }
                        break;
                    case "right":
                        {
                            int rowDemanded = int.Parse(Console.ReadLine());
                            int colDemanded = int.Parse(Console.ReadLine());
                            if (colDemanded < 0)
                            {
                                colDemanded = 0;
                            }
                            if (colDemanded > width)
                            {
                                colDemanded = width - 1;
                            }
                            matrix[rowDemanded] = PushZeroesRight(matrix, rowDemanded, colDemanded);
                        }
                        break;
                    case "stop":
                        for (int col = 0; col < width; col++)
                        {
                            int charCounter = 0;

                            for (int row = 0; row < 8; row++)
                            {
                                if (matrix[row][col] == '0')
                                {
                                    charCounter++;
                                }
                            }

                            if (charCounter == 8)
                            {
                                count++;
                            }
                        }

                        for (int i = 0; i < 8; i++)
                        {
                            ulong number = Convert.ToUInt64(matrix[i], 2);
                            sum += number;
                        }

                        sum *= (ulong)count;

                        //            PrintMatrix(matrix, 8, width);
                        Console.WriteLine(sum);
                        return;
                    default:
                        break;
                }
            }
        }

        private static string PushZeroesRight(string[] matrix, int inputRow, int inputCol)
        {
            string result = string.Empty;
            int count = 0;
            char[] convertedRow = matrix[inputRow].ToCharArray();

            for (int col = inputCol; col < convertedRow.Length; col++)
            {
                if (convertedRow[col] == '1')
                {
                    count++;
                    convertedRow[col] = '0';
                }
            }

            for (int col = convertedRow.Length - 1; col >= inputCol; col--)
            {
                if (count > 0)
                {
                    convertedRow[col] = '1';
                    count--;
                }
                else
                {
                    convertedRow[col] = '0';
                }
            }

            foreach (var item in convertedRow)
            {
                result = result + item;
            }

            return result;
        }

        public static string PullZeroesLeft(string[] matrix, int inputRow, int inputCol)
        {
            int count = 0;
            char[] convertedRow = matrix[inputRow].ToCharArray();
            string result = string.Empty;

            if (convertedRow.Length == inputCol)
            {
                for (int col = 0; col < inputCol; col++)
                {
                    if (convertedRow[col] == '1')
                    {
                        count++;
                        convertedRow[col] = '0';
                    }
                }

                for (int col = 0; col < inputCol; col++)
                {
                    if (count > 0)
                    {
                        convertedRow[col] = '1';
                        count--;
                    }
                    else
                    {
                        convertedRow[col] = '0';
                    }
                }
            }
            else if (true)
            {
                for (int col = 0; col <= inputCol; col++)
                {
                    if (convertedRow[col] == '1')
                    {
                        count++;
                        convertedRow[col] = '0';
                    }
                }

                for (int col = 0; col <= inputCol; col++)
                {
                    if (count > 0)
                    {
                        convertedRow[col] = '1';
                        count--;
                    }
                    else
                    {
                        convertedRow[col] = '0';
                    }
                }
            }



            foreach (var item in convertedRow)
            {
                result = result + item;
            }

            return result;
        }
        public static void PrintMatrix(string[] matrix, int matrixRow, int width)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(matrix[row][col]);
                }

                Console.WriteLine();
            }
        }
    }
}
