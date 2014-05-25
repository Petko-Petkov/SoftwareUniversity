/*Write a program that safely compares floating-point numbers with precision eps = 0.000001.
 * Note that we cannot directly compare two floating-point numbers a and b by a==b because 
 * of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal 
 * if they are more closely to each other than a fixed constant eps. Examples:*/

namespace ComparingFloats
{
    using System;

    class ComparingFloatsMain
    {
        static void Main()
        {
            float firstNumber = 1.23456789f;
            float secondNumber = 1.23456798f;
            bool equal = (firstNumber - secondNumber) < 0.000001;

            Console.WriteLine(equal);
        }
    }
}
