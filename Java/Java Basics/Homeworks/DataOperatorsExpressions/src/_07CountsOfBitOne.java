/*Write a program to calculate the count of bits 1 in the binary representation of given integer number n. */

import java.util.Scanner;

public class _07CountsOfBitOne {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		int number = input.nextInt();
		int counter = 0;
		
		while (number != 0) {
			if((number & 1) == 1){
				counter++;
			}
			
			number >>= 1;
		}
		input.close();
		System.out.println(counter);
	}

}
