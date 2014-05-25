//import java.util.Scanner;


/* Write a program to find all increasing sequences inside an array of integers. The integers 
 * are given in a single line, separated by a space. Print the sequences in the order of their 
 * appearance in the input array, each at a single line. Separate the sequence elements by a space.  
 * Find also the longest increasing sequence and print it at the last line. If several sequences 
 * have the same longest length, print the leftmost of them.
"2", "3", "4", "1", "50", "2", "3", "4", "5"				2 3 4
															1 50
															2 3 4 5
															Longest: 2 3 4 5
"8", "9", "9", "9", "-1", "5", "2", "3"						8 9
															9
															9
															-1 5
															2 3
															Longest: 8 9
"1", "2", "3", "4", "5", "6", "7", "8", "9" 				1 2 3 4 5 6 7 8 9
															Longest: 1 2 3 4 5 6 7 8 9
"5", "-1", "10", "20", "3", "4"								5
															-1 10 20
															3 4
															Longest: -1 10 20
*/

public class _04LongestIncreasingSequence {

	public static void main(String[] args) {		//here is how we can fill int[] from a string
//		Scanner input = new Scanner(System.in);			// for easier checking I've hardcoded the input
//		String string = input.nextLine();
//		String[] strArr = string.split(" ");
//		int[] intArr = new int[strArr.length]
		String[] arr = new String[]{"5", "-1", "10", "20", "3", "4"	};
		int[] numbers = new int[arr.length];
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = Integer.parseInt(arr[i]);
		}
		int counterTemp = 1;
		int counter = 1;
		int intPosition = 0; 

		System.out.print(numbers[0]);
		for (int i = 1; i < arr.length; i++) {
			if (numbers[i] > numbers[i - 1]) {
				counterTemp++;
				System.out.print(" " + numbers[i]);
			} else {
				counterTemp = 1;
				System.out.println();
				System.out.print(numbers[i]);
			}
			if (counterTemp > counter) {
				counter = counterTemp;
				intPosition = i;
			}
		}
		System.out.println();

		System.out.print("Longest: ");
		for (int j = 0; j < counter - 1; j++) {
			// positionOfWord - (counter - 1) + j
			System.out.print(numbers[intPosition - counter + 1 + j] + " ");
		}
		System.out.println(numbers[intPosition]);
	}
}
