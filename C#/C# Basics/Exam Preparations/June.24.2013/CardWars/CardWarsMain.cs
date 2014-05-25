namespace CardWars
{
    using System;

    class CardWarsMain
    {
        static void Main()
        {
            int totalGames = int.Parse(Console.ReadLine());
            string input;
            int firstPlayerScore = 0;
            int secondPlayerScore = 0;
            int firstPlayerTotalGamesWon = 0;
            int secondPlayerTotalGamesWon = 0;

            while (totalGames > 0)
            {
                int firstPlayerCurrentScore = 0;
                int secondPlayerCurrentScore = 0;
                bool xCard = false;
                totalGames--;
                bool tie = false;
                bool xCardTwo = false;

                for (int i = 0; i < 3; i++)
                {
                    input = Console.ReadLine();

                    if (input == "X")
                    {
                        xCard = true;
                        firstPlayerCurrentScore += 50;
                    }

                    firstPlayerCurrentScore += CalculateScore(input);
                }

                for (int i = 0; i < 3; i++)
                {
                    input = Console.ReadLine();

                    if (xCard)
                    {
                        if (input == "X")
                        {
                            secondPlayerCurrentScore += 50;
                            tie = true;
                        }
                        else
                        {
                            secondPlayerCurrentScore += CalculateScore(input);

                        }
                    }

                    if (input == "X")
                    {
                        secondPlayerCurrentScore += 50;
                        xCardTwo = true;
                    }
                    secondPlayerCurrentScore += CalculateScore(input);
                }

                if (tie)
                {
                    if (tie & xCard)
                    {
                        firstPlayerScore += firstPlayerCurrentScore;
                        secondPlayerScore += secondPlayerCurrentScore;
                        continue;
                    }
                }
                else if (!tie & xCard)
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    return;
                }
                else if (xCardTwo)
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    return;
                }
                else
                {

                    if (firstPlayerCurrentScore > secondPlayerCurrentScore)
                    {
                        firstPlayerScore += firstPlayerCurrentScore;
                        firstPlayerTotalGamesWon++;
                    }
                    else if (secondPlayerCurrentScore > firstPlayerCurrentScore)
                    {
                        secondPlayerScore += secondPlayerCurrentScore;
                        secondPlayerTotalGamesWon++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (firstPlayerScore > secondPlayerScore)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", firstPlayerScore);
                Console.WriteLine("Games won: {0}", firstPlayerTotalGamesWon);
            }
            else if (secondPlayerScore > firstPlayerScore)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", secondPlayerScore);
                Console.WriteLine("Games won: {0}", secondPlayerTotalGamesWon);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", firstPlayerScore);
            }
        }

        public static int CalculateScore(string input)
        {
            int result = 0;

            switch (input)
            {
                case "2": result += 10; break;
                case "3": result += 9; break;
                case "4": result += 8; break;
                case "5": result += 7; break;
                case "6": result += 6; break;
                case "7": result += 5; break;
                case "8": result += 4; break;
                case "9": result += 3; break;
                case "10": result += 2; break;
                case "J": result += 11; break;
                case "Q": result += 12; break;
                case "K": result += 13; break;
                case "A": result += 1; break;
                case "Z": result += result *= 2; break;
                case "Y": result += result -= 200; break;
                default:
                    break;
            }

            return result;
        }
    }
}
