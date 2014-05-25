import java.util.Arrays;
import java.util.Scanner;

/*Write a program to enter a number n and n integer numbers and sort and print them. 
 * Keep the numbers in array of integers: int[]. Examples:
Input	Output
7
6 5 4 10 -3 120 4	-3 4 4 5 6 10 120
3
10 9 8	8 9 10
1
999	999
*/
public class _01SortArrayOfnumbers {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		int count = input.nextInt();
		int[] arr = new int[count];
		
		for (int i = 0; i < arr.length; i++) {
			arr[i] = input.nextInt();
		}
		
		input.close();
		Arrays.sort(arr);
		
		for (int i = 0; i < arr.length; i++) {
			System.err.println(arr[i]);
		}

	}

}
