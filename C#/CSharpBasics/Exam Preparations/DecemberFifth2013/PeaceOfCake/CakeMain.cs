namespace PeaceOfCake
{
    using System;
    using System.Threading;

    class CakeMain
    {
        static void Main()
        {
            //Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentCulture;

            var a = long.Parse(Console.ReadLine());
            var b = long.Parse(Console.ReadLine());
            var c = long.Parse(Console.ReadLine());
            var d = long.Parse(Console.ReadLine());
            
            decimal nominator = a * d + b * c;
            decimal denominator = b * d;
            
            decimal result = nominator / denominator;

            if (result > 1)
            {
                Console.WriteLine((long)nominator / (long)denominator);
            }
            else
            {
                Console.WriteLine("{0:F22}", result);
            }

            Console.WriteLine("{0}/{1}", nominator, denominator);
        }
    }
}
