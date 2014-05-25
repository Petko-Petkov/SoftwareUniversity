/*Write a program that reads a number n and a sequence of n integers, sorts them and prints them. */
namespace SortingNumbers
{
    using System;
    using System.Collections.Generic;

    class SortingNumbersMain
    {
        static void Main()
        {
            Console.WriteLine("Input an integer for the length of the list: ");
            int numbersCount = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            Console.WriteLine("Input {0} count integers", numbersCount);
            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            numbers.Sort();

            Console.WriteLine("Sorted integers: ");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
