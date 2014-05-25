/*Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. */

namespace RandomNumbersInRange
{
    using System;

    class RandomizerMain
    {
        static void Main()
        {
            Console.WriteLine("Input the count of the random numbers you want : ");
            var count = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the minimal value : ");
            var min = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the maximum value : ");
            var max = int.Parse(Console.ReadLine());

            Random rand = new Random();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Number {0} - {1}",i + 1, rand.Next(min, max)); 
            }
        }
    }
}
