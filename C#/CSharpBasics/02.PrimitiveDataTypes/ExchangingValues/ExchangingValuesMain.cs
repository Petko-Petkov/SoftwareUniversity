/*Declare two integer variables a and b and assign them with 5 and 10 
 * and after that exchange their values. Print the variable values before and after the exchange.*/

namespace ExchangingValues
{
    using System;

    class ExchangingValuesMain
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c = a;

            Console.WriteLine("Initial value of variable a = {0}", a);
            Console.WriteLine("Initial value of variable b = {0}", b);

            a = b;
            b = c;

            Console.WriteLine();
            Console.WriteLine("Exchanged value of variable a = {0}", a);
            Console.WriteLine("Exchanged value of variable b = {0}", b);
        }
    }
}
