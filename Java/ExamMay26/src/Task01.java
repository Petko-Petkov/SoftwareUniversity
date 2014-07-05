import java.text.MessageFormat;
import java.util.ArrayList;
import java.util.Scanner;

public class Task01 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int minutes = 0;
		int hours = 0;
		String[] string = input.nextLine().split(":");
		hours += Integer.parseInt(string[0]);
		minutes += Integer.parseInt(string[1]);
		while (true) {
			String str = input.nextLine();
			
			if (str.equals("End")) {
				break;
			} else {	
				string = str.split(":");
				hours += Integer.parseInt(string[0]);
				minutes += Integer.parseInt(string[1]);
			}			
		}
		if (minutes%60 < 10) {
			System.out.println(MessageFormat.format("{0}:0{1}", hours + minutes / 60, minutes % 60));
		}else {
			System.out.println(MessageFormat.format("{0}:{1}", hours + minutes / 60, minutes % 60));
		}
		
	}

}
