import java.util.ArrayList;
import java.util.Scanner;

public class Task03 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine().trim();
		String toStringArr = str.replaceAll("\\s+", "");
		String finalString = toStringArr.substring(1, toStringArr.length() - 1);
		String[] strArr = finalString.split("\\]\\[");
		int maxSum = Integer.MIN_VALUE;

		ArrayList<Integer> list = new ArrayList<>();
		
		for (int i = 0; i < strArr.length; i++) {
			String[] intStrings = strArr[i].split("x");
			int first = Integer.parseInt(intStrings[0]);
			int second = Integer.parseInt(intStrings[1]);
			list.add(first*second);
		}
		
		for (int i = 0; i < list.size() -2; i++) {
			int currentSum = list.get(i) + list.get(i+1)+list.get(i+2);
			if (currentSum>maxSum) {
				maxSum = currentSum;
			}
		}
		
		System.out.println(maxSum);
	}

	static boolean tryParseInt(String value) {
		try {
			Integer.parseInt(value);
			return true;
		} catch (NumberFormatException nfe) {
			return false;
		}
	}
}
