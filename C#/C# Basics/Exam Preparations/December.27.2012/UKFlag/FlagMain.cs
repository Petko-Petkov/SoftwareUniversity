namespace UKFlag
{
    using System;
    using Helper;
    class FlagMain
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string[] array = new string[input];

            for (int i = (input / 2) - 1; i >= 0; i--)
            {
                array[3 - i] = string.Format("{0}\\{1}|{1}/{0}", new string('.', 3 - i), new string('.', i));
                array[input - (4 - i)] = string.Format("{0}/{1}|{1}\\{0}", new string('.', 3 - i), new string('.', i));
            }

            array[input / 2] = string.Format("{0}*{0}", new string('-', input/2));
            Helper.PrintArrayMatrix(array, string.Empty);
        }
    }
}
