/*Write a program that counts how many times a given word occurs in given text. The first line in the input 
 * holds the word. The second line of the input holds the text. The output should be a single integer number – 
 * the number of word occurrences. Matching should be case-insensitive. Note that not all matching substrings 
 * are words and should be counted. A word is a sequence of letters separated by punctuation or start / end of text. */
namespace CountingWordInText
{
    using System;

    class WordCounter
    {
        static void Main(string[] args)
        {
            string searchedWord = "SoftUni".ToLower();
            string input = "The Software University (SoftUni) trains software engineers, gives them a\n profession and a job. Visit us at http://softuni.bg. Enjoy the \nSoftUnification at SoftUni.BG. Contact us.Email: INFO@SOFTUNI.BG. \nFacebook: https://www.facebook.com/SoftwareUniversity. YouTube: \nhttp://www.youtube.com/SoftwareUniversity. Google+: \nhttps://plus.google.com/+SoftuniBg/. Twitter: \nhttps://twitter.com/softunibg. GitHub: https://github.com/softuni";

            string[] arr = input.Split(new char[] { ' ', '.', ',', '"', '@', '!', '?', '/', '\\', ':', ';', '(', ')' }, StringSplitOptions.None);
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToLower() == searchedWord)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
