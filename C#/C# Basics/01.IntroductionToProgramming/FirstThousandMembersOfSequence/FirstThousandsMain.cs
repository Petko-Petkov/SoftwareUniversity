/*Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, 
 * … You might need to learn how to use loops (search in Internet).*/

namespace FirstThousandMembersOfSequence
{
    using System;

    class FirstThousandsMain
    {
        static void Main()
        {
            int counter = 0;
            
            //Using for loop with two indexers for printing the members of the sequence
            for (int i = 2, j = -3; i <= 1000; i+=2, j-=2)
            {
                counter++;
                Console.WriteLine("[{0}] - {1}", counter, i);
                counter++;
                Console.WriteLine("[{0}] - {1}", counter, j);
            }
        }
    }
}
