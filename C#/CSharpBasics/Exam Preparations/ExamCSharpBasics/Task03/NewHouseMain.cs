namespace Task03
{
    using System;

    class NewHouseMain
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int roof = input / 2 + 1;
            int houseHeight = input + roof;
            string[] house = new string[houseHeight];
            int astCounter = 1;

            for (int i = 0; i < roof; i++)
            {
                house[i] = string.Format("{0}{1}{0}", new string('-', roof - i -1), new string('*', astCounter));
                astCounter += 2;
            }

            for (int i = roof; i < houseHeight; i++)
            {
                house[i] = string.Format("{0}{1}{0}", '|', new string('*', input - 2));
            }

            PrintArrayMatrix(house, string.Empty);
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
