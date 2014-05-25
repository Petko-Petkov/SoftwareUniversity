/*Write a program that reads a list of names and prints for each name how many times it appears in the list. 
 * The names should be listed in alphabetical order. Use the input and output format from the examples below. */
namespace CountOfNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class NameCounterMain
    {
        static void Main()
        {
            Dictionary<string, int> letters = new Dictionary<string, int>();
            string input = "Nakov Nakov Nakov SoftUni Nakov"; //"Peter Steve Nakov Steve Alex Nakov";       
            string[] arr = input.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                if (letters.ContainsKey(arr[i]))
                {
                    letters[arr[i]] = letters[arr[i]] + 1;
                }
                else
                {
                    letters.Add(arr[i], 1);
                }
            }

            var list = letters.Keys.ToList();
            list.Sort();

            // Loop through keys.
            foreach (var key in list)
            {
                Console.WriteLine("{0} -> {1}", key, letters[key]);
            }
        }
    }
}
