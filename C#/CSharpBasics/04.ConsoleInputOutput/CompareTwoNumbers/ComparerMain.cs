/*Write a program that gets two numbers from the console and prints 
 * the greater of them. Try to implement this without if statements. */

namespace CompareTwoNumbers
{
    using System;

    class ComparerMain
    {
        static void Main()
        {
            Console.WriteLine("Input two numbers: ");

            var inputA = double.Parse(Console.ReadLine());
            var inputB = double.Parse(Console.ReadLine());

            Console.WriteLine("The greater number is : ", Math.Max(inputA, inputB));
        }
    }
}
