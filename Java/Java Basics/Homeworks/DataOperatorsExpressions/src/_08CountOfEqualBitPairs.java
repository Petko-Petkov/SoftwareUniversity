/*Write a program to count how many sequences of two equal bits ("00" or "11") 
 * can be found in the binary representation of given integer number n (with overlapping). */

import java.util.Scanner;


public class _08CountOfEqualBitPairs {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		int number = input.nextInt();
		
		int firstBit;
		int secondBit;
		int counter = 0;
		
		//Check if the input is zero
		if (number != 0) {
			firstBit = number & 1;
			//If the number is negative >> operator causes endless loop
			//So i check the number and determine the operator
			if (number > 0) {
				number >>= 1;	
			}else {
				number >>>= 1;
			}
		}else {
			System.out.println(0);
			input.close();
			return;
		}
		
		//Check if the input is one
		if (number != 0) {
			secondBit = number & 1;
			if (number > 0) {
				number >>= 1;	
			}else {
				number >>>= 1;
			}
		}else {
			System.out.println(0);
			input.close();
			return;
		}
		
		while (number != 0) {
			if (firstBit == secondBit) {
				counter++;
			}
			
			int thirdBit = number & 1;
			firstBit = secondBit;
			secondBit = thirdBit;
			
			//If the number is negative >> operator causes endless loop
			//So i check the number and determine the operator
			if (number > 0) {
				number >>= 1;
			}else {
				number >>>= 1;
			}
			
		}
		
		if (firstBit == secondBit) {
			counter++;
		}
		
		System.out.println(counter);
		input.close();
	}
}
