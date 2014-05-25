/*Write a program that reads a list of letters and prints for each letter how many times it appears in the list. 
 * The letters should be listed in alphabetical order. Use the input and output format from the examples below. */
namespace CountOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountOfLettersMain
    {
        static void Main()
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            string input = "h d h a a a s d f d a d j d s h a a";       //"b b a a b";

            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] < 'a' || input[i] > 'z'))
                {
                    continue;
                }
                if (letters.ContainsKey(input[i]))
                {
                    letters[input[i]] = letters[input[i]] + 1;
                }
                else
                {
                    letters.Add(input[i], 1); 
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
