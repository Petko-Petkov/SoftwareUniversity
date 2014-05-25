/*Write a program that finds the biggest of three numbers. */

namespace BiggestOfThreeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BiggestMain
    {
        static void Main()
        {
            List<double> list = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                var input = double.Parse(Console.ReadLine());

                list.Add(input);
            }

            list.Sort();
            
            Console.WriteLine(list[list.Count -1]);
        }
    }
}
