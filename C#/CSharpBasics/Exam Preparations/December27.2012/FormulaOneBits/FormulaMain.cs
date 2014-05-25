namespace FormulaOneBits
{
    using System;

    class FormulaMain
    {
        static void Main()
        {
            string[] matrix = new string[8];
            bool gameOver = false;
            bool trackNotFinished = false;
            int trackLength = 1;
            int turnCount = 0;
            int currentRow = 0;
            int currentCol = 7;
            int direction = 1;
            int mod = -1;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(matrix.Length, '0');
            }

            while (!gameOver && !trackNotFinished)
            {
                if (Check(direction, currentRow, currentCol, matrix) == 0)
                {
                    Move(direction, ref currentRow, ref currentCol);
                    trackLength++;
                }
                else if (Check(direction, currentRow, currentCol, matrix) == 1) 
                {
                    ChangeDirection(ref direction, ref mod);

                    if (Check(direction, currentRow, currentCol, matrix) == 0)
                    {
                        Move(direction, ref currentRow, ref currentCol);
                        trackLength++;
                        turnCount++;
                    }
                    else
                    {
                        trackNotFinished = true;
                        continue;
                    }
                }
                else if (Check(direction, currentRow, currentCol, matrix) == 2)
                {
                    gameOver = true;
                    continue;
                }
                else
                {
                    ChangeDirection(ref direction, ref mod);

                    if (Check(direction, currentRow, currentCol, matrix) == 0)
                    {
                        Move(direction, ref currentRow, ref currentCol);
                        trackLength++;
                        turnCount++;
                    }
                    else
                    {
                        trackNotFinished = true;
                        continue;
                    }
                }
            }

            if (trackNotFinished)
            {
                Console.WriteLine("No {0}", trackLength);
            }
            else
            {
                Console.WriteLine("{0} {1}", trackLength, turnCount);
            }
        }

        private static void Move(int direction, ref int row, ref int col)
        {
            switch (direction)
            {
                case 1:
                    {
                        row++;
                    }
                    break;
                case 2:
                    {
                        col--;
                    }
                    break;
                case 3:
                    {
                        row--;
                    }
                    break;
            }
        }

        private static int Check(int direction, int row, int col, string[] matrix)
        {
            try
            {
                Move(direction, ref row, ref col);

                if (matrix[row][col] == '0')
                {
                    return 0;
                }

                return 1;
            }
            catch (Exception)
            {
                if (row == 8 && col == 0)
                {
                    return 2;
                }

                return 3;
            }
        }

        private static void ChangeDirection(ref int direction, ref int mod)
        {
            if (direction == 3 || direction == 1)
            {
                mod *= -1;
            }

            direction += mod;
        }
    }
}
