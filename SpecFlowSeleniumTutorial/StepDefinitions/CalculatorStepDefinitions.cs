using SpecFlowSeleniumTutorial.Drivers;
using SpecFlowSeleniumTutorial.Pages;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumTutorial.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly CalculatorPageObject _calculatorPage;

        public CalculatorStepDefinitions(BrowserDriver browserDriver)
        {
            _calculatorPage = new CalculatorPageObject(browserDriver.Current);
        }


        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            _calculatorPage.EnterFirstNumber(number.ToString());
            
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            _calculatorPage.EnterSecondNumber(number.ToString());
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            _calculatorPage.ClickAdd();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            //TODO: implement assert (verification) logic

            var actualResult = _calculatorPage.WaitForNonEmptyResult();
            actualResult.Should().Be(expectedResult.ToString());
        }
    }
}