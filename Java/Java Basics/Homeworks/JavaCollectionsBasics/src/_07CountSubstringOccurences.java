import java.util.Scanner;

/*Write a program to find how many times given string appears in given text as substring. The text is given
 *  at the first input line. The search string is given at the second input line. The output is an integer 
 *  number. Please ignore the character casing. Examples:
Input									Output
Welcome to the Software University (SoftUni)! Welcome to programming. Programming is wellness for developers, said Maxwell.
wel										4
aaaaaa
aa										5
ababa caba
aba										3
Welcome to SoftUni
Java									0
*/
public class _07CountSubstringOccurences {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine().toLowerCase();
		String searchedSubstring = input.nextLine().toLowerCase();
		input.close();
		int counter = 0;
		
		for (int i = 0; i < str.length() - searchedSubstring.length(); i++) {
			if (str.substring(0+i, i+searchedSubstring.length()).equals(searchedSubstring)) {
				counter++;
			}
		}
		
		if (str.substring(str.length() - searchedSubstring.length(), str.length()).equals(searchedSubstring)) {
			counter++;
		}
		System.out.println(counter);
	}

}
