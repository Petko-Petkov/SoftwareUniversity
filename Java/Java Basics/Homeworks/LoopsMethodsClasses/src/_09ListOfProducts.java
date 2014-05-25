/*Create a class Product to hold products, which have name (string) and price (decimal number). 
 * Read from a text file named "Input.txt" a list of products. Each product will be in format 
 * name + space + price. You should hold the products in objects of class Product. Sort the products 
 * by price and write them in format price + space + name in a file named "Output.txt". Ensure you close correctly all used resources. */

import java.io.*;
import java.util.*;

public class _09ListOfProducts {

	public static void main(String[] args) {

		ArrayList<Product> products = new ArrayList<>();
		try {
			BufferedReader reader = new BufferedReader(new FileReader("products.txt"));
			String line = null;
			
			while ((line = reader.readLine()) != null) {
				String[] currentLine = line.split(" ");
				products.add(new Product(currentLine[0], Double.parseDouble(currentLine[1])));
			}

			Collections.sort(products);
			
			BufferedWriter writer = new BufferedWriter(new FileWriter("output.txt"));
			
			for (Product product2 : products) {
				writer.write(product2.getPrice() + " " + product2.getName() + "\r\n");
			}
			
			reader.close();
			writer.close();
			
		} catch (FileNotFoundException e) {
			System.out.println("Missing file.");
		} catch (IOException e) {
			System.out.println("Empty file.");
		}
	}
}
