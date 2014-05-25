/*Write a program to find the longest word in a text.*/
namespace LongestWordInText
{
    using System;

    class LongestWordMain
    {
        static void Main()
        {
            //string test = "Welcome to the Software University.";
            string text = "The C# Basics course is awesome start in programming with C# and Visual Studio.";
            string[] words = text.Split(new char[] { ' ', ',', ':', ';', '.' },
                                                StringSplitOptions.RemoveEmptyEntries);

            int longestWord = 0;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > words[longestWord].Length)
                {
                    longestWord = i;
                }
            }

            Console.WriteLine(words[longestWord]);

        }
    }
}
