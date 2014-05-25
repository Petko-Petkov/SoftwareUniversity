/*Write an if-statement that takes two integer variables a and b and exchanges their values 
 * if the first one is greater than the second one. As a result print the values a and b, separated by a space. */

namespace ExchangeIfGreater
{
    using System;

    class ExchangerMain
    {
        static void Main()
        {
            Console.WriteLine("Input two numbers each on a separate line.");

            var firstValue = double.Parse(Console.ReadLine());
            var secondValue = double.Parse(Console.ReadLine());
            double thirdValue;
            if (firstValue > secondValue)
            {
                thirdValue = firstValue;
                firstValue = secondValue;
                secondValue = thirdValue;
            }

            Console.WriteLine("{0} {1}",firstValue, secondValue );
        }
    }
}
