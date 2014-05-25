/*Create a program that assigns null values to an integer and to a double variable. 
 * Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.*/ 

namespace NullValues
{
    using System;

    class NullValuesMain
    {
        static void Main(string[] args)
        {
            int? nullableInteger = null;
            double? nullableDouble = null;

            Console.WriteLine(nullableInteger);
            Console.WriteLine(nullableDouble);
        }
    }
}
