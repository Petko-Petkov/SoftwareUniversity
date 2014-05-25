/**/

namespace TrailingZeroes
{
    using System;
    using System.Numerics;

    class ZeroesMain
    {
        static void Main()
        {
            Console.WriteLine("Input an integer (if you enter a bigger integer just be patient for the result) : ");
            var input = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            var count = 0;

            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }

            BigInteger last = 0;

            do
            {
                last = result % 10;
                result /= 10;
                count++;
            } while (last == 0);

            count--;

            Console.WriteLine(count);
        }
    }
}
