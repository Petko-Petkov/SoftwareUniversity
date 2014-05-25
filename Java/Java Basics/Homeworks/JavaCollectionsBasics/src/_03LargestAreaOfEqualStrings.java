/*Write a program that enters an array of strings and finds in it the largest sequence of equal 
 * elements. If several sequences have the same longest length, print the leftmost of them. The 
 * input strings are given as a single line, separated by a space. Examples:
Input															Output
"hi", "yes", "yes", "yes", "bye"								yes yes yes
"SoftUni", "softUni", "softuni"									SoftUni
"1", "1", "2", "2", "3", "3", "4", "4", "5", "5"				1 1
"a", "b", "b", "xxx", "c", "c", "c"								c c c
"hi", "hi", "hi", "hi", "hi"									hi hi hi hi hi
"hello"															hello
*/
public class _03LargestAreaOfEqualStrings {

	public static void main(String[] args) {
		String[] strArr = new String[]{"hello"};
		int longestSeq = 0;
		int tmpcounter = 1;
		String longestStr = "";
		
		for (int i = 1; i < strArr.length; i++) {
			
			if (strArr[i].equals(strArr[i-1])) {
				tmpcounter++;
			}else {
				tmpcounter=1;
			}
			if (tmpcounter>longestSeq) {
				longestSeq = tmpcounter;
				longestStr = strArr[i];
			}			
		}
		if (strArr.length == 1) {
			System.err.println(strArr[0]);
		}
		for (int j = 0; j < longestSeq; j++) {
			System.out.print(longestStr+" ");
		}
	}
}
