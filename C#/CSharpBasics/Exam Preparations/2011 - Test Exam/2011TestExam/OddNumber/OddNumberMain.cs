namespace OddNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class OddNumberMain
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            List<long> list = new List<long>();

            for (int i = 0; i < input; i++)
            {
                long number = long.Parse(Console.ReadLine());
                
                list.Add(number);
            }

            list.Sort();
            while (list[0] == list[1])
            {
                if (list[0] == list[1])
                {
                    list.Remove(list[0]);
                    list.Remove(list[0]);
                }

                if (list.Count == 1)
                {
                    break;
                }
            }            

            Console.WriteLine(list[0]);
        }
    }
}
