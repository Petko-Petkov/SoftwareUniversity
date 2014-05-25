import java.util.Scanner;

/*Write a program to find how many times a word appears in given text. The text is given at the first input line.
 *  The target word is given at the second input line. The output is an integer number. Please ignore the 
 *  character casing. Consider that any non-letter character is a word separator. Examples:
Input																	Output
Welcome to the Software University (SoftUni)! Welcome to programming.
welcome																	2
I am coming...
hello																	0
It's OK, I'm in.
i																		1
*/
public class _06CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();
		String searchedWord = input.nextLine().toLowerCase();
		String[] strArr = str.split("\\W+");
		int counter = 0;
		input.close();
		
		for (int i = 0; i < strArr.length; i++) {
			if (strArr[i].toLowerCase().equals(searchedWord)) {
				counter++;
			}
		}
		
		System.out.println(counter);
	}

}
