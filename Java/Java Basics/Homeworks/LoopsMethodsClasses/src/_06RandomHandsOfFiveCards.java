/*Write a program to generate n random hands of 5 different cards form a standard suit of 52 cards. */

import java.util.*;

public class _06RandomHandsOfFiveCards {

	public static void main(String[] args) {

		char[] suits = new char[] { '\u2663', '\u2666', '\u2665', '\u2660' };		
		ArrayList<String> deckOfCards = new ArrayList<>();
		generateDeck(deckOfCards, suits);
		Scanner input = new Scanner(System.in);
		int inputNumber = input.nextInt();
		
		for (int i = 0; i < inputNumber; i++) {

			Collections.shuffle(deckOfCards);
			System.out.printf("%s %s %s %s %s", deckOfCards.get(0), deckOfCards.get(1),
					deckOfCards.get(2),deckOfCards.get(3),deckOfCards.get(4) );
			System.out.println();
		}
		
		input.close();
	}

	private static void generateDeck(ArrayList<String> deckOfCards, char[] suits) {
		String result = "";
		for (int i = 2; i <= 14; i++) {

			for (int j = 0; j < suits.length; j++) {

				switch (i) {
				case 11:
					result = " J";
					break;
				case 12:
					result = " Q";
					break;
				case 13:
					result = " K";
					break;
				case 14:
					result = " A";
					break;
				default:
					result = " " + i;
					break;
				}
				
				result = result + suits[j];
				deckOfCards.add(result);
			}
		}		
	}	
}
