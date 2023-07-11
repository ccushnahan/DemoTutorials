using SpecFlowSeleniumTutorial.Drivers;
using SpecFlowSeleniumTutorial.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumTutorial.Hooks
{
    [Binding]
    public class CalculatorHooks
    {
        [BeforeScenario("Calculator")]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var calculatorPageObject = new CalculatorPageObject(browserDriver.Current);
            calculatorPageObject.EnsureCalculatorIsOpenAndReset();
        }
    }
}
