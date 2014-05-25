namespace AngryFemaleGPS
{
    using System;

    class FemaleGPSMain
    {
        static void Main()
        {
            var input = long.Parse(Console.ReadLine());
            long evenSum = 0;
            long oddSum = 0;
            if (input < 0)
            {
                input *= -1;
            }

            while (input != 0)
            {
                var number = input % 10;
                input /= 10;

                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            if (evenSum < oddSum)
            {
                Console.WriteLine("left {0}", oddSum);
            }
            else if (evenSum > oddSum)
            {
                Console.WriteLine("right {0}", evenSum);
            }
            else if (evenSum == oddSum)
            {
                Console.WriteLine("straight {0}", evenSum);
            }
        }
    }
}
