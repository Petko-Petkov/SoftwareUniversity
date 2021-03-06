import java.util.Collections;
import java.util.Comparator;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedHashMap;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;
import java.util.Scanner;


public class Task04 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] strArr = input.nextLine().split(" ");
		Map<String, Integer> mapStr = new HashMap<>();
		
		for (int i = 0; i < strArr.length - 1; i++) {
			String currentString = strArr[i] + " " + strArr[i+1];
			Integer count = mapStr.get(currentString);
			if (count == null) {
				count = 0;
			}
			mapStr.put(currentString, count+1);
		}
		
		


		for (Map.Entry<String, Integer> strEntry : mapStr.entrySet()) {
			System.out.printf("%s -> %.2f%%\n", strEntry.getKey(), (double)strEntry.getValue()*100/(strArr.length -1));
		}
	}

}
