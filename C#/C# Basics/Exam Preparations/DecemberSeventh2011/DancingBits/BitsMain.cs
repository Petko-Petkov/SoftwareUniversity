namespace DancingBits
{
    using System;

    class BitsMain
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            int count = 0;
            int bit;
            int tempCounter = 1;
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                string tmpStr = string.Empty;

                while (number > 0)
                {
                    bit = number & 1;
                    number >>= 1;
                    tmpStr = bit + tmpStr;
                }

                result = result + tmpStr;
            }

            for (int i = 1; i < result.Length; i++)
            {
                char prevChecked = result[i-1];

                if (result[i] == prevChecked)
                {
                    tempCounter++;
                }
                else
                {
                    if (tempCounter == k)
                    {
                        count++;
                    }

                    tempCounter = 1;
                }
            }

            if (tempCounter == k)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
