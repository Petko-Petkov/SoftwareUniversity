import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

/*At the first line at the console you are given a piece of text. Extract all words from it and print them in 
 * alphabetical order. Consider each non-letter character as word separator. Take the repeating words only once.
 *  Ignore the character casing. Print the result words in a single line, separated by spaces. Examples:
Input														Output
Welcome to SoftUni. Welcome to Java.						java to softuni welcome
What is better: Java SE or Java EE?							better ее is java or se what 
hello														hello
*/
public class _10ExtractUniqueWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();
		input.close();
		
		String[] strArr = str.split("\\W+");
		ArrayList<String> strList = new ArrayList<>();
		
		for (int i = 0; i < strArr.length; i++) {
			if (!strList.contains(strArr[i].toLowerCase())) {
				strList.add(strArr[i].toLowerCase());
			}
		}
		
		Collections.sort(strList);

		for (String s : strList) {
			System.out.print(s + " ");
		}

	}

}
