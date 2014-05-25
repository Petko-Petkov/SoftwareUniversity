/*Write a program to find the longest area of equal elements in array of strings. 
 * You first should read an integer n and n strings (each at a separate line), 
 * then find and print the longest sequence of equal elements (first its length, then its elements). 
 * If multiple sequences have the same maximal length, print the leftmost of them. */

namespace LongestAreaInArray
{
    using System;
    using System.Collections.Generic;

    class LongestAreaMain
    {
        static void Main()
        {
            int strCount = int.Parse(Console.ReadLine());
            int longestSequence = 0;
            string maxElement = string.Empty;
            int currentSequence = 1;

            List<string> strings = new List<string>();

            for (int i = 0; i < strCount; i++)
            {
                string input = Console.ReadLine();

                strings.Add(input);
            }

            for (int i = 1; i < strCount; i++)
            {
                string currentStr = strings[i - 1];

                if (strings[i] == strings[i-1])
                {
                    if (currentSequence > longestSequence)
                    {
                        maxElement = currentStr;
                        longestSequence = currentSequence;
                    }

                    currentSequence++;
                }
                else 
                {
                    currentSequence = 1;
                }

                if (maxElement == string.Empty)
                {
                    maxElement = currentStr;
                }
            }

            Console.WriteLine(longestSequence + 1);

            for (int i = 0; i < longestSequence + 1; i++)
            {
                Console.WriteLine(maxElement);
            }
        }
    }
}
