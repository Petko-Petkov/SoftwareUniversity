namespace Tribonacci
{
    using System;
    using System.Numerics;

    class TribonacciMain
    {
        static void Main()
        {
            var first = BigInteger.Parse(Console.ReadLine());
            var second = BigInteger.Parse(Console.ReadLine());
            var third = BigInteger.Parse(Console.ReadLine());
            var elementN = BigInteger.Parse(Console.ReadLine());
            BigInteger tmp = 0;

            if (elementN == 1)
            {
                Console.WriteLine(first);
            }
            else if (elementN == 2)
            {
                Console.WriteLine(second);
            }
            else if (elementN == 3)
            {
                Console.WriteLine(third);
            }
            else
            {
                for (int i = 3; i < elementN; i++)
                {
                    tmp = first + second + third;
                    first = second;
                    second = third;
                    third = tmp;
                }


                Console.WriteLine(tmp);
            }
        }
    }
}
