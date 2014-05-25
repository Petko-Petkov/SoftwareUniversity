/**/

namespace SumOfFiveNumbers
{
    using System;

    class SumMain
    {
        static void Main()
        {
            Console.WriteLine("Input 5 number separated by withespace.");

            var input = Console.ReadLine().Split(' ');
            var sum = 0.0;
            double number;

            foreach (var item in input)
            {
                
                number = double.Parse(item);
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
