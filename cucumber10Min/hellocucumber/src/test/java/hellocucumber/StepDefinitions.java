package hellocucumber;

import io.cucumber.java.en.*;

import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.Assertions.*;

class IsItFriday {
	static String isItFriday(String today) {
		return "Friday".equals(today) ? "TGIF" : "Nope";
	}
}

public class StepDefinitions {

	private String today;
	private String actualAnswer;
    
    @Given("today is Sunday")
    public void today_is_sunday() {
    	today = "Sunday";
    }
    
    @Given("today is Friday")
    public void today_is_Friday() {
        today = "Friday";
    }
    
    @Given("^today is \"(.*)\"$")
    public void today_is(String today) {
        this.today = today;
    }
    
    @When("I ask whether it's Friday yet")
    public void i_ask_whether_it_s_friday_yet() {
    	actualAnswer = IsItFriday.isItFriday(today); 
    }

    @Then("^I should be told \"(.*)\"$")
    public void i_should_be_told(String expectedAnswer) {
        // Write code here that turns the phrase above into concrete actions
        assertEquals(expectedAnswer, actualAnswer);
    }

}
