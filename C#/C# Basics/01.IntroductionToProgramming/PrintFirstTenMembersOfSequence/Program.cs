/*Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...*/

namespace PrintFirstTenMembersOfSequence
{
    using System;

    class Program
    {
        static void Main()
        {
            for (int i = 2, j = -3; i <= 10; i+=2, j-=2)
            {
                Console.Write(i + ", ");
                Console.Write(j + ", ");
            }

            Console.WriteLine();
        }
    }
}
