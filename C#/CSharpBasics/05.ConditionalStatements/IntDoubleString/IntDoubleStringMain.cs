/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
 * If the variable is int or double, the program increases it by one. If the variable is a string, 
 * the program appends "*" at the end. Print the result at the console. Use switch statement. */

namespace IntDoubleString
{
    using System;

    class IntDoubleStringMain
    {
        static void Main()
        {
            var choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine("Please enter an integer: ");
                    var inputInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(++inputInt);
                    break;
                case 2: Console.WriteLine("Please enter a double: ");
                    var inputDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine(++inputDouble);
                    break;
                case 3: Console.WriteLine("Please enter a string: ");
                    var inputString = Console.ReadLine();
                    Console.WriteLine(inputString + '*');
                    break;
                default:
                    break;
            }
        }
    }
}
