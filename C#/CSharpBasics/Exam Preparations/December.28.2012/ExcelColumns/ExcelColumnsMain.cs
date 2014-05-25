namespace ExcelColumns
{
    using System;

    class ExcelColumnsMain
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int number;
            double result = 0;
            double powed = count - 1;

            for (int i = 0; i < count; i++)
            {
                number = char.Parse(Console.ReadLine());
                number -= 'A' - 1;
                result += Math.Pow(26, powed) * number;
                powed--;
            }

            Console.WriteLine(result);
        }
    }
}
