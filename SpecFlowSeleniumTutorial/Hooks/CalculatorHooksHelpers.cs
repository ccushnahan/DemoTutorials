using SpecFlowSeleniumTutorial.Drivers;
using SpecFlowSeleniumTutorial.Pages;

internal static class CalculatorHooksHelpers
{
    [BeforeScenario("Calculator")]
    public static void BeforeScenario(BrowserDriver browserDriver)
    {
        var calculatorPageObject = new CalculatorPageObject(browserDriver.Current);
        calculatorPageObject.EnsureCalculatorIsOpenAndReset();
    }
}