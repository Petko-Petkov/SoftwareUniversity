namespace SubsetSum
{
    using System;
    using System.Collections.Generic;

    class SubsetSumMain
    {
        static void Main()
        {
            long sum = long.Parse(Console.ReadLine());
            int numbersCount = int.Parse(Console.ReadLine());
            List<long> numbers = new List<long>();

            for (int i = 0; i < numbersCount; i++)
            {
                long number = long.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            long tempSum = 0;
            int count = 0;

            foreach (var num in numbers)
            {
                tempSum += num;

                if (tempSum == sum)
                {
                    count++;
                }
                else if (tempSum < sum)
                {
                    continue;
                }
                else
                {

                }
            }
        }
    }
}
