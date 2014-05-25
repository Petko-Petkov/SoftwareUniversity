import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

/*We are given a sequence of N playing cards from a standard deck. The input consists of several cards 
 * (face + suit), separated by a space. Write a program to calculate and print at the console the frequency
 *  of each card face in format "card_face -> frequency". The frequency is calculated by the formula appearances
 *   / N and is expressed in percentages with exactly 2 digits after the decimal point. The card faces with their
 *    frequency should be printed in the order of the card face's first appearance in the input. The same card 
 *    can appear multiple times in the input, but it's face should be listed only once in the output. Examples:
Input																		Output
8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦												8 -> 10.00%
																			2 -> 10.00%
																			4 -> 10.00%
																			10 -> 20.00%
																			J -> 10.00%
																			A -> 10.00%
																			K -> 30.00%
J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠													J -> 22.22%
																			2 -> 77.78%
10♣ 10♥																		10 -> 100.00%
*/
public class _12CardFrequencies {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] cardsStr = input.nextLine().split("[♥♣♦♠ ]+");
		Map<String, Integer> cardsMap = new HashMap<String, Integer>();
		
		for (String str : cardsStr) {
			Integer count = cardsMap.get(str);
			if (count == null) {
				count = 0;
			}
			
			cardsMap.put(str, count+1);
		}
		
		for (Map.Entry<String, Integer> strEntry : cardsMap.entrySet()) {
			System.out.printf("%s -> %.2f%%\n", strEntry.getKey(), (double)strEntry.getValue()*100/cardsStr.length);
		}

	}

}
