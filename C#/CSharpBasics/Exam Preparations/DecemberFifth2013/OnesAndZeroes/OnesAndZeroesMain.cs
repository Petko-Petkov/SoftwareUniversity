namespace OnesAndZeroes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class OnesAndZeroesMain
    {
        static void Main(string[] args)
        {
            string binary = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(32, '0');
            Dictionary<int, Dictionary<char, string>> map = new Dictionary<int, Dictionary<char, string>>();
            Dictionary<char, string> digitMap = new Dictionary<char,string>();

            byte num1 = 164;
            num1 <<= 3;
            num1 >>= 3;
            Console.WriteLine(num1);

            map.Add(0, new Dictionary<char, string> { { '0', "###" }, { '1', ".#." } });
            map.Add(1, new Dictionary<char, string> { { '0', "#.#" }, { '1', "##." } });
            map.Add(2, new Dictionary<char, string> { { '0', "#.#" }, { '1', ".#." } }); 
            map.Add(3, new Dictionary<char, string> { { '0', "#.#" }, { '1', ".#." } });
            map.Add(4, new Dictionary<char, string> { { '0', "###" }, { '1', "###" } });

            for (int i = 0; i < 5; i++)
            {
                for (int a = 16; a < 32; a++)
                {
                    Console.Write(map[i][binary[a]]);
                    if (a != 31)
                    {
                        Console.Write('.');
                    }
                }

                Console.WriteLine();
            }
            //char[,] matrix = new char[5, 63];
            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < 63; col++)
            //    {
            //        matrix[row, col] = '.';
            //    }
            //}

            

            //for (int i = 16, pos = 0; i < 32; i++, pos += 4)
            //{
            //    PutDigit(matrix, binary[i], pos);
            //}

            //PrintMatrix(matrix);
        }

        public static void PutDigit(char[,] matrix, char digit, int position)
        {
            char[,] zero = new char[,] { 
                {'#','#','#'},
                {'#','.','#'},
                {'#','.','#'},
                {'#','.','#'},
                {'#','#','#'}
            };

            char[,] one = new char[,] { 
                {'.','#','.'},
                {'#','#','.'},
                {'.','#','.'},
                {'.','#','.'},
                {'#','#','#'}
            };
            switch (digit)
            {
                case '0':
                    {
                        InsertPattern(matrix, zero, position);
                    }
                    break;
                case '1':
                    {
                        InsertPattern(matrix, one, position);
                    }
                    break;
            }
        }

        public static void InsertPattern(char[,] matrix, char[,] pattern, int position)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = position; col < position + 3; col++)
                {
                    int patternCol = col - position;
                    matrix[row, col] = pattern[row, patternCol];
                }
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
