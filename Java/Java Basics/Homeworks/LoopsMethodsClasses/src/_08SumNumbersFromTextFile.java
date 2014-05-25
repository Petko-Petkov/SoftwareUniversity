/*Write a program to read a text file "Input.txt" holding a sequence of integer numbers, 
 * each at a separate line. Print the sum of the numbers at the console. Ensure you close 
 * correctly the file in case of exception or in case of normal execution. In case of exception 
 * (e.g. the file is missing), print "Error" as a result. */

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class _08SumNumbersFromTextFile {

	public static void main(String[] args) throws IOException {
		
		try {
			BufferedReader reader = new BufferedReader(new FileReader("input.txt"));
			String line = null;
			int sum = 0;
			
			while ((line=reader.readLine()) != null) {
				sum += Integer.parseInt(line);
			}
			reader.close();
			System.out.println(sum);
		} catch (FileNotFoundException e) {
			
			System.out.println("Error");
		}
		
		
	}

}
