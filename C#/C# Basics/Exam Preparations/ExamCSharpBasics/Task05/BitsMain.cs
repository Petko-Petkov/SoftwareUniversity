namespace Task05
{
    using System;

    class BitsMain
    {
        static void Main()
        {
            byte bytesCount = byte.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            string inputString = string.Empty;
            string result = string.Empty;
            int bitPosition = 1;

            for (int i = 0; i < bytesCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                inputString = inputString + Convert.ToString(number, 2).PadLeft(8, '0');
            }

            long limits = bytesCount * 8;

            for (long i = 0; i < limits; i++)
            {
                long currentStep = bitPosition + step * i;
                if (currentStep < limits)
                {
                    result += inputString[(int)currentStep];
                }
                else
                {
                    break;
                }
            }

            if (result.Length < 8)
            {
                result = result.PadRight(8, '0');
            }
            else if(result.Length > 8)
            {
                if (result.Length % 8 != 0)
                {
                    result = result.PadRight(8 - (result.Length % 8) + result.Length, '0');   
                }
            }

            long limit = result.Length / 8;
            
            for (long i = 0; i < limit; i++)
            {
                int number = Convert.ToInt32(result.Substring(0, 8), 2);
                Console.WriteLine(number);
                result = result.Remove(0, 8);
            }  
        }
    }
}

