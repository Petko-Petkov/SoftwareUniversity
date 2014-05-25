/*Write a program that enters the sides of a rectangle (two integers a and b) and calculates and prints the rectangle's area. */
import java.util.Scanner;

public class _01RectangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		float sideA = input.nextInt();
		float sideB = input.nextInt();
		float area = calculateRectangleArea(sideA, sideB);
		System.out.println(area);
		input.close();
	}

	private static float calculateRectangleArea(float sideA, float sideB) {
		return sideA * sideB;
		
	}	
}
