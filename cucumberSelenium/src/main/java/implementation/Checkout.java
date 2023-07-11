package implementation;

public class Checkout {
	
	private int total;
	
	public Checkout() {
		this.total = 0;
	}
	
	public void add(int count, int price) {
		this.total += (count * price);
	}
	
	public int total() {
		return this.total;
	}
}
