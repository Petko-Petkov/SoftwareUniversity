/*Write a program that enters 3 points in the plane (as integer x and y coordinates), calculates and prints the area 
 * of the triangle composed by these 3 points. Round the result to a whole number. In case the three points do not 
 * form a triangle, print "0" as result. */

import java.util.Scanner;

public class _02TriangleArea {

	public static void main(String[] args) {
		int aX, aY, bX, bY, cX, cY;
		Scanner input = new Scanner(System.in);
		aX = input.nextInt();
		aY = input.nextInt();
		bX = input.nextInt();
		bY = input.nextInt();
		cX = input.nextInt();
		cY = input.nextInt();

		int area = calculateTriangleArea(aX, aY, bX, bY, cX, cY);
		System.out.println(area);
		input.close();
	}

	private static int calculateTriangleArea(int aX, int aY, int bX, int bY,int cX, int cY) {
		
		int area = aX*(bY - cY) + bX*(cY - aY) + cX*(aY - bY);
		return Math.abs(area/2);
	}

}
