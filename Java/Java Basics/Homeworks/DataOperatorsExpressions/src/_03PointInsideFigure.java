import java.util.Scanner;

/*Write a program to check whether a point is inside or outside of the figure below. 
 * The point is given as a pair of floating-point numbers, separated by a space.
 *  Your program should print "Inside" or "Outside". */

public class _03PointInsideFigure {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		String temp = input.nextLine();
		
		String[] coordinates = temp.split(" ");
		
		float pointA = Float.parseFloat(coordinates[0]);
		float pointB = Float.parseFloat(coordinates[1]);
		
		if(pointA < 12.5 || pointA > 22.5){
			System.out.println("Outside");
		}else{
			if(pointB >= 6 && pointB <= 13.5){
				System.out.println("Inside");
			}else{
				System.out.println("Outside");
			}
		}
		input.close();
	}

}
