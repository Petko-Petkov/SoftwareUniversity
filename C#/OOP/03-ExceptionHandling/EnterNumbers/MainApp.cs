namespace EnterNumbers
{
    using System;
    using System.Collections.Generic;

    public class MainApp
    {
        public static void Main()
        {
            const int End = 100;
            int start = 1;
            List<int> nums = new List<int>(10);

            for (int i = 0; i < nums.Capacity; i++)
            {
                bool isValid = false;

                do
                {
                    try
                    {
                        string currentInput = Console.ReadLine();
                        int currentNumber = InputNumber(start, End, currentInput);

                        if (currentNumber is int)
                        {
                            isValid = true;
                            nums.Add(currentNumber);
                        }

                        start = currentNumber;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Input a valid number!");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Please input a number in the range [" + start + "..." + End + "]");
                    }
                }
                while (!isValid);
            }

            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public static int InputNumber(int start, int end, string input)
        {
            int result;

            if (int.TryParse(input, out result))
            {
                if (result < end && result > start)
                {
                    return result;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
