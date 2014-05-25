namespace ZeroSubsets

{
    using System;

    class SubsetsMain
    {
        static void Main()
        {
            int n = 5;
            long[] nums = new long[n];
            string currentSum = string.Empty;

            for (int i = 0; i < n; i++)
            {
                nums[i] = long.Parse(Console.ReadLine());
            }

            int maxI = 1;

            for (int i = 1; i <= 5; i++)
            {
                maxI *= 2;
            }

            maxI -= 1;

            for (int i = 1; i <= maxI; i++)
            {
                long currSum = 0;

                for (int j = 0; j < n; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;

                    if (bit == 1)
                    {
                        currSum += nums[j];
                        currentSum += nums[j].ToString();
                    }
                }

                if (currSum == 0)
                {
                    for (int j = 0; j < currentSum.Length; j++)
                    {
                        Console.Write(currentSum[j]);

                        if (currentSum[j] == '-')
                        {
                            continue;
                        }
                        else if (j != currentSum.Length - 1)
                        {
                            Console.Write(" + ");
                        }
                        else
                        {
                            Console.Write(" = 0");
                            Console.WriteLine();
                        }
                    }

                    currentSum = string.Empty;
                }
                else
                {
                    currentSum = string.Empty;
                }
            }
        }
    }
}