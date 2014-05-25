namespace Lines
{
    using System;

    class LinesMain
    {
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
        static void Main()
        {
            string[] array = new string[8];
            array = FillArrayMatrix(8, 8);
            //PrintArrayMatrix(array, " ");
            int maxRowLength = 0;
            int maxColLentgh = 0;
            int counter = 0;

            for (int row = 0; row < 8; row++)
            {
                int tempRowLength = 0;

                for (int col = 0; col < 8; col++)
                {
                    if (array[row][col] == '1')
                    {
                        tempRowLength++;

                        if (tempRowLength > maxRowLength)
                        {
                            maxRowLength = tempRowLength;
                            counter = 1;
                        }
                        else if (tempRowLength == maxRowLength)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        tempRowLength = 0;
                    }
                }

                //Console.WriteLine(maxRowLength);
                //Console.WriteLine(counter);
                //PrintArrayMatrix(array, " ");
            }

            int tmpMaxColCount = 0;

            for (int col = 0; col < 8; col++)
            {
                int tempColLength = 0;

                for (int row = 0; row < 8; row++)
                {
                    if (array[row][col] == '1')
                    {
                        tempColLength++;

                        if (tempColLength > maxColLentgh)
                        {
                            maxColLentgh = tempColLength;
                            tmpMaxColCount = 1;
                        }
                        else if (tempColLength == maxColLentgh)
                        {
                            tmpMaxColCount++;
                        }

                        //if (maxColLentgh > maxRowLength)
                        //{
                        //    tmpMaxColCount++;
                        //    counter = tmpMaxColCount;
                        //}

                        //if ((maxColLentgh == maxRowLength) || (maxColLentgh == tempColLength))
                        //{
                        //    counter++;
                        //}
                    }
                    else
                    {
                        tempColLength = 0;
                    }
                }
            }

            int output = 0;

            if (maxRowLength > maxColLentgh)
            {
                output = maxRowLength;
            }
            else if (maxRowLength == maxColLentgh)
            {
                output = maxRowLength;
                counter += tmpMaxColCount;
            }
            else
            {
                output = maxColLentgh;
                counter = tmpMaxColCount;
            }

            if ((maxRowLength == 1) && (maxColLentgh) == 1)
            {
                Console.WriteLine(1);
                Console.WriteLine(counter / 2);
                return;
            }

            Console.WriteLine(output);
            Console.WriteLine(counter);
        //    int first = int.Parse(Console.ReadLine());
        //    int second = int.Parse(Console.ReadLine());
        //    int third = int.Parse(Console.ReadLine());
        //    int fourth = int.Parse(Console.ReadLine());
        //    int fifth = int.Parse(Console.ReadLine());
        //    int sixth = int.Parse(Console.ReadLine());
        //    int seventh = int.Parse(Console.ReadLine());
        //    int eight = int.Parse(Console.ReadLine());

        //    int[] array = new int[] { first, second, third, fourth, fifth, sixth, seventh, eight};
        //    int maxRow = 0;
        //    int count = 0;
        //    int maxCol = 0;
        //    int colCount = 0;

        //    foreach (var item in array)
        //    {
        //        int tempMaxRow = 0;
        //        int number = item;

        //        while (number > 0)
        //        {
        //            if ((number & 1) == 1)
        //            {
        //                tempMaxRow++;
        //            }
        //            else
        //            {
        //                if (tempMaxRow > maxRow)
        //                {
        //                    maxRow = tempMaxRow;
        //                    count = 0;

        //                    if (tempMaxRow == maxRow)
        //                    {
        //                        count++;
        //                    }
        //                }

        //                tempMaxRow = 0;
        //            }

        //            number >>= 1;
        //        }

        //        if (tempMaxRow > maxRow)
        //        {
        //            count = 0;
        //            maxRow = tempMaxRow;

        //            if (tempMaxRow == maxRow)
        //            {
        //                count++;
        //            }
        //        }
        //    }

        //    int[] colArr = new int[8];

        //    foreach (var item in array)
        //    {
        //        int number = item;
        //        int bit;

        //        for (int i = 0; i < 8; i++)
        //        {
        //            int maxTmpCol = 0;
        //            bit = number & 1;
        //            number >>= 1;

        //            if ((colArr[i - 1] == 1) && (bit == 1))
        //            {
        //                colArr[i]++;
        //            }
        //            else
        //            {
        //                colArr[i] = maxTmpCol;
        //                colArr[i] = 0;

        //                if (maxTmpCol > maxCol)
        //                {
        //                    maxCol = maxTmpCol;
        //                }
        //            }
        //        }
        //    }

        //    Console.WriteLine(maxRow);
        //    Console.WriteLine(count);
        }
    }
}
