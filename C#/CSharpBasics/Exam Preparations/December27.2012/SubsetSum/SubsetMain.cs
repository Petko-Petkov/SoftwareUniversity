namespace SubsetSum
{
    using System;
    using System.Text;

    class SubsetMain
    {
        static void Main()
        {
            var sumSearched = long.Parse(Console.ReadLine());
            var count = int.Parse(Console.ReadLine());
            long[] digits = new long[count];

            for (int i = 0; i < count; i++)
            {
                digits[i] = long.Parse(Console.ReadLine()); 
            }

            long counter = 0;

            for (int i = 1; i < Math.Pow(2, count); i++)
            {
                string mask = Convert.ToString(i,2).PadLeft(count, '0');
                long sum = 0;

                for (int j = 0; j < count; j++)
                {
                    if (mask[j] == '1')
                    {
                        sum += digits[j];
                    }
                }

                if (sum == sumSearched)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
