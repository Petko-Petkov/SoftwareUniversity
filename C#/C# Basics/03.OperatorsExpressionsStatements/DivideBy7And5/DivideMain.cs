/*Write a Boolean exdpression that checks for given integer if 
 * it can be divided (without remainder) by 7 and 5 in the same time.*/

namespace DivideBy7And5
{
    using System;

    class DivideMain
    {
        static void Main()
        {
            ////Taking an integer from the user 
            int input = int.Parse(Console.ReadLine());

            //Checking if it is dividable by 7 * 5 and write it on the console
            if (input % 35 != 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
