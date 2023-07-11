package stepDefinitions;

import io.cucumber.java.en.*;
import io.cucumber.java.PendingException;
import implementation.Checkout;
import static org.junit.jupiter.api.Assertions.assertEquals;

import java.util.HashMap;

public class CheckoutSteps {
	
	private Checkout checkout;
	private HashMap<String, Integer> itemPrices; 
	
	public CheckoutSteps() {
		this.itemPrices = new HashMap<String, Integer>();
		this.checkout = new Checkout();
	}
	
	@Given("^the price of a \"(.*?)\" is (\\d+)c$")
	public void the_price_of_a_is_b(String itemName, int price) {
		this.itemPrices.put(itemName, price);
	}

	@When("^I checkout (\\d+) \"(.*?)\"$")
	public void i_checkout(Integer itemCount, String itemName) {
		int itemPrice = this.itemPrices.get(itemName);
		checkout.add(itemCount, itemPrice);
	}

	@Then("^the total price should be (\\d+)c$")
	public void the_total_price_should_be_a(int total) {
		assertEquals(total, checkout.total());
	}
}
