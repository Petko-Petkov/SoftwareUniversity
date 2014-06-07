import java.text.MessageFormat;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

/*Write a program to find the most frequent word in a text and print it, as well as how many times it appears
 *  in format "word -> count". Consider any non-letter character as a word separator. Ignore the character 
 *  casing. If several words have the same maximal frequency, print all of them in alphabetical order. Examples:
 Input																				Output
 in the middle of the night															the -> 2 times
 Welcome to SoftUni. Welcome to Java. Welcome everyone.								welcome -> 3 times
 Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.	come -> 2 times
 																					darling -> 2 times
 																					hello -> 2 times
 																					my -> 2 times
 																					welcome -> 2 times */
public class _11MostFrequentWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();
		input.close();
		String[] strArr = str.split("\\W+");

		Map<String, Integer> wordsMap = new HashMap<>();
		int mostFrequent = 0;
		
		for (String word : strArr) {
			Integer count = wordsMap.get(word);
			
			if (count == null) {
				count = 0;
			}
			
			if (count + 1 > mostFrequent) {
				mostFrequent = count + 1;
			}
			
			wordsMap.put(word.toLowerCase(), count+1);
		}
		
		for (Map.Entry<String, Integer> entry : wordsMap.entrySet()) {
			if (entry.getValue()==mostFrequent) {
				System.out.println(MessageFormat.format("{0} -> {1}", entry.getKey(), entry.getValue()));
			}			
		}		
	}
}
