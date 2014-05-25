/*Write a program to check whether a point is inside or outside the house below. The point is given
 *  as a pair of floating-point numbers, separated by a space. Your program should print "Inside" or "Outside". */
import java.util.Locale;
import java.util.Scanner;

public class _09PointsInsideTheHouse {

	public static void main(String[] args) {

		Locale.setDefault(Locale.ROOT);
		Scanner input = new Scanner(System.in);
		String temp = input.nextLine();
		String[] coordinates = temp.split(" ");
		double x = Double.parseDouble(coordinates[0]);
		double y = Double.parseDouble(coordinates[1]);

		double x1 = 12.5, y1 = 8.5;
		double x2 = 17.5, y2 = 3.5;
		double x3 = 22.5, y3 = 8.5;

		double abc = Math.abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
		double abp = Math.abs(x1 * (y2 - y) + x2 * (y - y1) + x * (y1 - y2));
		double apc = Math.abs(x1 * (y - y3) + x * (y3 - y1) + x3 * (y1 - y));
		double pbc = Math.abs(x * (y2 - y3) + x2 * (y3 - y) + x3 * (y - y2));

		boolean isInTriangle = false;
		if (abp + apc + pbc == abc) {
			isInTriangle = true;
		}

		if ((x >= 12.5 && x <= 17.5) && (y <= 13.5 && y >= 8.5)) {
			System.out.println("Inside");
		} else if ((x >= 20 && x <= 22.5) && (y <= 13.5 && y >= 8.5)) {
			System.out.println("Inside");
		} else if (isInTriangle) {
			System.out.println("Inside");
		} else {
			System.out.println("Outside");
		}
		input.close();
	}
}