namespace MissCat
{
    using System;

    class MissCatMain
    {
        static void Main()
        {
            int votesTotal = int.Parse(Console.ReadLine());
            int[] cats = new int[11];
            int bestCat = 0;
            int bestVotedCat = 0;

            for (int i = 1; i <= votesTotal; i++)
            {
                int vote = int.Parse(Console.ReadLine());
                cats[vote]++;

                if (bestVotedCat < cats[vote])
                {
                    bestVotedCat = cats[vote];
                    bestCat = vote;
                }
            }

            Console.WriteLine(bestCat);
        }
    }
}
