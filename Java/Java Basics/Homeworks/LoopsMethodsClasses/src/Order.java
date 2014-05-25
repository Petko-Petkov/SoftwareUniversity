
public class Order {
	
	private Double quantity;
	private Product  product;
	
	public Order (double quantity, Product product){
		
		this.quantity = quantity;
		this.product = product;
	}
	
	public Double getQuantity() {
		return quantity;
	}
	public void setQuantity(Double quantity) {
		this.quantity = quantity;
	}
	public Product getProduct() {
		return product;
	}
	public void setProduct(Product product) {
		this.product = product;
	}
	
	
}
