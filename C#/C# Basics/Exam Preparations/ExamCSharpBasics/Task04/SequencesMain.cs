namespace Task04
{
    using System;
    using System.Collections.Generic;

    class SequencesMain
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int spiralStart = int.Parse(Console.ReadLine());
            int spiralStepInitial = int.Parse(Console.ReadLine());
            int tribToCompare = 0;
            int spiralToCompare = spiralStart;
            int spiralCounter = 0;
            int currentSpiralStep = spiralStepInitial;
            List<int> spiral = new List<int>();
            spiral.Add(spiralStart);

            while (true)
            {                
                ++spiralCounter;
                if (spiralCounter > 2)
                {
                    currentSpiralStep += spiralStepInitial;
                    spiralCounter = 1;
                }
                spiralToCompare = Spiral(spiralToCompare, currentSpiralStep);
                if (spiralToCompare > 1000000)
                {
                    break;
                }
                spiral.Add(spiralToCompare);
            }

            if (spiral.Contains(first))
            {
                Console.WriteLine(first);
                return;
            }
            //else if (spiral.Contains(second))
            //{
            //    Console.WriteLine(second);
            //    return;
            //}
            //else if (spiral.Contains(third))
            //{
            //    Console.WriteLine(third);
            //    return;
            //}

            while (tribToCompare < spiral[spiral.Count -1])
            {
                tribToCompare = Tribonacci(first, second, third);
                first = second;
                second = third;
                third = tribToCompare;

                if (spiral.Contains(tribToCompare))
                {
                    Console.WriteLine(tribToCompare);
                    return;
                }
            }

            Console.WriteLine("No");
        }

        public static int Tribonacci(int first, int second, int third)
        {
            int result = first + second + third;
            return result;
        }

        public static int Spiral(int start, int step)
        {
            int result = start + step;
            return result;
        }
    }
}
