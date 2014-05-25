/*Write a program that takes as input two lists of names and removes from the first list all names 
 given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line. */
namespace RemoveNames
{
    using System;
    using System.Collections.Generic;

    class RemoveNamesMain
    {
        static void Main()
        {
            //string givenList = "Peter Alex Maria Todor Steve Diana Steve";
            //string namesToDelete = "Todor Steve Nakov";
            string givenList = "Hristo Hristo Nakov Nakov Petya";
            string namesToDelete = "Nakov Vanessa Maria";

            List<string> names = new List<string>(givenList.Split(' '));

            List<string> name = new List<string>(namesToDelete.Split(' '));

            foreach (var n in name)
            {
                if (names.Contains(n))
                {
                    names.RemoveAll(x => x == n);
                }
            }

            foreach (var item in names)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
