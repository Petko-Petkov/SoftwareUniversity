import java.util.ArrayList;
import java.util.Scanner;

/*Write a program that reads two lists of letters l1 and l2 and combines them: appends all letters c from 
 * l2 to the end of l1, but only when c does not appear in l1. Print the obtained combined list. All lists
 *  are given as sequence of letters separated by a single space, each at a separate line. 
 *  Use ArrayList<Character> of chars to keep the input and output lists. Examples:
Input										Output
h e l l o
l o w										h e l l o w
a b c d
x y z										a b c d x y z
a b a
b a b a										a b a
w e l c o m e t o s o f t u n i
j a v a p r o g r a m m i n g				w e l c o m e t o s o f t u n i j a v a p r g r a g
*/
public class _09CombineListsOfLetters {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String firstString = input.nextLine();
		String secondString = input.nextLine();
		input.close();
		
		ArrayList<Character> firstList = fillLists(firstString);
		ArrayList<Character> secondList = fillLists(secondString);
		
		secondList.removeAll(firstList);
		firstList.addAll(secondList);
		
		for (Character ch : firstList) {
			if (ch != ' ') {
				System.out.print(ch + " ");	
			}
		}

	}

	private static ArrayList<Character> fillLists(String str) {
		ArrayList<Character> list = new ArrayList<>();
		
		for (int i = 0; i < str.length(); i++) {
			list.add(str.charAt(i));
		}
		
		return list;
	}

}
