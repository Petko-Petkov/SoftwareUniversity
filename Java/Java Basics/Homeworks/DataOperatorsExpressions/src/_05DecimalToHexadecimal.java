/*Write a program that enters a positive integer number num and converts and prints it 
 * in hexadecimal form. You may use some built-in method from the standard Java libraries. */

import java.util.Scanner;


public class _05DecimalToHexadecimal {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int number = input.nextInt();
		String hexNumber = Integer.toHexString(number);
		System.out.printf("0x%s", hexNumber.toUpperCase());
		input.close();
	}

}
