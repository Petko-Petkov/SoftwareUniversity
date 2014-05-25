/**/

namespace RandomiseFromOneToN
{
    using System;
    using System.Collections.Generic;
    
    class RandomizerToNMain
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            List<int> array = new List<int>();
            int current = 1;

            for (int i = 0; i < n; i++)
            {
                array.Add(current);
                current++;
            }

            Random r = new Random();

            while (array.Count > 0)
            {
                int index = r.Next(array.Count);
                Console.Write(array[index] + " ");
                array.RemoveAt(index);
            }

            Console.WriteLine();
        }
    }
}
