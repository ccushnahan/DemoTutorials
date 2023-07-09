Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Scenario-1 @Addition
Scenario Outline: Add two numbers
	Given the first number is <FirstNum>
	And the second number is <SecondNum>
	When the two numbers are added
	Then the result should be <Result>
	
	Examples:
		| FirstNum | SecondNum | Result |
		| 50       | 70        | 120    |
		| 10       | 10        | 20     |
		| 0        | -20       | -20    |

@Scenario-2 @Subtraction
Scenario Outline: Subtract two numbers
	Given the first number is <FirstNum>
	And the second number is <SecondNum>
	When the two numbers are subtracted
	Then the result should be <Result>

	Examples:
		| FirstNum | SecondNum | Result |
		| 50       | 70        | -20    |
		| 10       | 10        | 0      |
		| 0        | -20       | 20     |