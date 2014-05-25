/*Write a program that takes as input two lists of integers and joins them. The result should hold 
 * all numbers from the first list, and all numbers from the second list, without repeating numbers, 
 * and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line.*/
namespace JoinLists
{
    using System;
    using System.Collections.Generic;

    class JoinListMain
    {
        static void Main()
        {
            //List<int> firstList = new List<int> { 20, 40, 10, 10, 30, 80 };
            //List<int> secondList = new List<int> { 25, 20, 40, 30, 10 };
            List<int> firstList = new List<int> { 5, 4, 3, 2, 1 };
            List<int> secondList = new List<int> { 6, 3, 2};
            firstList.Sort();
            secondList.Sort();

            for (int i = 1; i < firstList.Count; i++)
            {
                if (firstList[i] == firstList[i - 1])
                {
                    firstList.Remove(firstList[i]);
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (!firstList.Contains(secondList[i]))
                {
                    firstList.Add(secondList[i]);
                }
            }

            firstList.Sort();

            foreach (var item in firstList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
