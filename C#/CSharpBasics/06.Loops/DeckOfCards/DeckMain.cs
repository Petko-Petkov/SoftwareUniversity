/*Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
 * The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A.
 * Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.*/

namespace DeckOfCards
{
    using System;

    class DeckMain
    {
        static void Main()
        {
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            string[] suits = { "\u2665", "\u2666", "\u2663", "\u2660" };

            for (int card = 0; card < 13; card++)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    switch (suits[suit])
                    {
                        case "\u2665": 
                        case "\u2666": Console.ForegroundColor =  ConsoleColor.DarkRed; 
                            break;
                        case "\u2663":
                        case "\u2660": Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        default:
                            break;
                    }
                    Console.Write("{0, 3}{1}, ", cards[card], suits[suit]);                    
                }

                Console.WriteLine();
            }
        }
    }
}
