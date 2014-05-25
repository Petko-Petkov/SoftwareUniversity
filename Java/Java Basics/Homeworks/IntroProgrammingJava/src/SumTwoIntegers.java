/*Write a program SumTwoNumbers.java that enters two integers from the console, calculates and 
 * prints their sum. Search in Internet to learn how to read numbers from the console. */
import java.util.Scanner;


public class SumTwoIntegers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		int firstInt = input.nextInt();
		int secondInt = input.nextInt();
		
		int sum = firstInt + secondInt;
		
		System.out.printf("%d", sum);
		
		input.close(); 

	}

}
