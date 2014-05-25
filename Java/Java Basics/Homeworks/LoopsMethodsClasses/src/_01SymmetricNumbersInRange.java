/*Write a program to generate and print all symmetric numbers in given range [start…end] (0 ≤ start ≤ end ≤ 999).
 *  A number is symmetric if its digits are symmetric toward its middle. For example, the numbers 101, 33, 989 
 *  and 5 are symmetric, but 102, 34 and 997 are not symmetric. */

import java.util.Scanner;

public class _01SymmetricNumbersInRange {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		System.out.println("Input start number: ");
		int start = input.nextInt();
		System.out.println("Input end number: ");
		int end = input.nextInt();

		for (int i = start; i <= end; i++) {

			char[] intArr = Integer.toString(i).toCharArray();
			boolean symmetric = false;

			for (int j = 0; j < intArr.length / 2; j++) {
				int first = intArr[j];
				int last = intArr[intArr.length - j - 1];
				if (isSymmetryc(first, last)) {
					symmetric = true;
				} else {
					symmetric = false;
					continue;
				}
			}

			if (symmetric || i < 10) {
				System.out.printf("%d ", i);
			}						
		}
		
		input.close();
	}

	private static boolean isSymmetryc(int first, int last) {

		if (first == last) {
			return true;
		} else {
			return false;
		}
	}

}
