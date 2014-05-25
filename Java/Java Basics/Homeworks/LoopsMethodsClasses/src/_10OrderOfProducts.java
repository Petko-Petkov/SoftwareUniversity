import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Locale;

/*Create a class Product to hold products, which have name (string) and price (decimal number). 
 * Read from a text file named "Products.txt" a list of product with prices and keep them in a 
 * list of products. Each product will be in format name + space + price. You should hold the 
 * products in objects of class Product. Read from a text file named "Order.txt" an order of 
 * products with quantities. Each order line will be in format product + space + quantity. 
 * Calculate and print in a text file "Output.txt" the total price of the order. Ensure you close correctly all used resources. */

public class _10OrderOfProducts {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		ArrayList<Product> products = new ArrayList<>();
		ArrayList<Order> orderList = new ArrayList<>();
		try {
			BufferedReader readerList = new BufferedReader(new FileReader("products10.txt"));
			String line = null;
			
			while ((line = readerList.readLine()) != null) {
				String[] currentLine = line.split(" ");
				products.add(new Product(currentLine[0], Double.parseDouble(currentLine[1])));
			}
			
			line = null;
			readerList.close();
			
			BufferedReader readerOrder = new BufferedReader(new FileReader("order.txt"));
			Double order = 0.0;
			
			while ((line = readerOrder.readLine()) != null) {
				String[] currentLine = line.split(" ");
				orderList.add(new Order(Double.parseDouble(currentLine[0]), new Product(currentLine[1])));
			}

			for (Order ord : orderList) {
				
				Double singlePrice = getProductPrice(ord.getProduct().getName(), products);
				order += singlePrice * ord.getQuantity();
			}
			
			System.out.println(order);
			
			BufferedWriter writer = new BufferedWriter(new FileWriter("output-order.txt"));
			
			
			readerOrder.close();
			writer.close();
			
		} catch (FileNotFoundException e) {
			System.out.println("Missing file.");
		} catch (IOException e) {
			System.out.println("Empty file.");
		}

	}

	private static Double getProductPrice(String name, ArrayList<Product> products) {
		for (Product prd : products) {
			if (prd.getName().equals(name)) {
				return prd.getPrice();
			}
		}
		return null;
	}

}
