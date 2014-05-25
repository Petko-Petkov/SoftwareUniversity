/*Write a program that enters an array of strings and finds in it all sequences of equal elements.
 *  The input strings are given as a single line, separated by a space. Examples:
 Input	Output
 hi yes yes yes bye	
 hi
 yes yes yes
 bye
 SoftUni softUni softuni	
 SoftUni
 softUni
 softuni
 1 1 2 2 3 3 4 4 5 5	1 1
 2 2
 3 3
 4 4
 5 5
 a b b xxx c c c	a
 b b
 xxx
 c c c
 hi hi hi hi hi	hi hi hi hi hi
 hello	hello
 */
public class _02SequencesOfEqualStrings {

	public static void main(String[] args) {

		String[] strArr = new String[] {"hi", "yes", "yes", "yes", "bye"};

		for (int i = 0; i < strArr.length - 1; i++) {
			if (strArr[i].equals(strArr[i + 1])) {
				System.out.print(strArr[i] + " ");
			} else {
				System.out.println(strArr[i]);
			}
		}
		
		System.out.println(strArr[strArr.length-1]);

	}

}
