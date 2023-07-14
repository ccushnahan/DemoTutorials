
import org.junit.jupiter.api.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

import java.time.Duration;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class FirstSeleniumTest {
	
	@Test
	public void browserTest() {
		WebDriver driver = new ChromeDriver();
		
		driver.manage().timeouts().implicitlyWait(Duration.ofMillis(500));
		driver.get("https://www.selenium.dev/selenium/web/web-form.html");
		
		String title = driver.getTitle();
		
		WebElement textBox = driver.findElement(By.name("my-text"));
		WebElement submitButton = driver.findElement(By.cssSelector("button"));
		
		textBox.sendKeys("Selenium");
		submitButton.click();
		
		WebElement message = driver.findElement(By.id("message"));
		
		String value = message.getText();
		driver.quit();
	}
}