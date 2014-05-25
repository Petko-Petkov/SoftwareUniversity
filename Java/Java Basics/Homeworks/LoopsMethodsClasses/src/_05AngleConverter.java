/*Write a method to convert from degrees to radians. Write a method to convert from radians to degrees.
 *  You are given a number n and n queries for conversion. Each conversion query will consist of a number + space + measure.
 *   Measures are "deg" and "rad". Convert all radians to degrees and all degrees to radians. Print the results as n lines, 
 *   each holding a number + space + measure. Format all numbers with 6 digit after the decimal point. */

import java.util.Scanner;

public class _05AngleConverter {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);

		int lineCount = Integer.parseInt(input.nextLine());
		String[] inputArr = new String[lineCount];

		for (int i = 0; i < lineCount; i++) {
			inputArr[i] = input.nextLine();
			System.out.println(convertedUnit(inputArr[i]));
		}			
		
		input.close();
	}

	private static String convertedUnit(String string) {
		String[] str = string.split(" ");
		String result = "";
		Double unit = Double.parseDouble(str[0]);
		if (str[1].trim().startsWith("r")) {
			unit = Math.toDegrees(unit);
			result = String.format("%.6f deg", unit);
		}else {
			unit = Math.toRadians(unit);
			result = String.format("%.6f rad", unit);
		}
		return result;
	}
}
