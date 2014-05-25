/*Write a program that enters from the console number n and n strings, then sorts them alphabetically 
 * and prints them. Note: you might need to learn how to use loops and arrays in Java (search in Internet). */
import java.util.Arrays;
import java.util.Scanner;


public class SortArrayOfStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		String[] strArray = new String[5];
		
		for (int i = 0; i < strArray.length; i++) {
			strArray[i] = input.next();
		}
		
		Arrays.sort(strArray);
		
		for (int i = 0; i < strArray.length; i++) {
			System.out.println(strArray[i]);
		}
		
		input.close();

	}

}
