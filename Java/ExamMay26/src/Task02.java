import java.text.MessageFormat;
import java.util.ArrayList;
import java.util.Scanner;


public class Task02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int loops = input.nextInt();
		int[] intList = new int[loops];
		boolean found = false;
		
		for (int i = 0; i < loops; i++) {
			intList[i] = input.nextInt();
		}
		
		for (int i = 0; i < intList.length; i++) {
			for (int j = 0; j < intList.length; j++) {
				for (int k = 0; k < intList.length; k++) {
					if (intList[i]*intList[i]<= intList[j]*intList[j]) 
						if((intList[i]*intList[i]) + (intList[j]*intList[j]) == (intList[k]*intList[k])){							 
						System.out.println(MessageFormat.format("{0}*{0} + {1}*{1} = {2}*{2}", intList[i], intList[j], intList[k]));
						found = true;
					}
				}
			}
		}
		
		if (!found) {
			System.out.println("No");
		}

	}

}
