/*Write a program that finds the smallest of three numbers. */

import java.util.Scanner;

public class _04SmallestOfThreeNumbers {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		float a = Float.parseFloat(input.next());
		float b = Float.parseFloat(input.next());
		float c = Float.parseFloat(input.next());
		
		if (a < b) {
			if (a < c) {
				System.out.println(a);
			}else{
				System.out.println(c);
			}
			
		}else{
			if (b < c) {
				System.out.println(b);
			}else{
				System.out.println(c);
			}
		}
		input.close();
	}

}
