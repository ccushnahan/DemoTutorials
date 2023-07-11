using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowSeleniumTutorial.Pages
{
    public class CalculatorPageObject
    {
        private const string CalculatorURL = "https://specflowoss.github.io/Calculator-Demo/Calculator.html";

        private readonly IWebDriver _webDriver;

        public const int DefaultWaitInSeconds = 5;

        public CalculatorPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement FirstNumberElement => _webDriver.FindElement(By.Id("first-number"));
        private IWebElement SecondNumberElement => _webDriver.FindElement(By.Id("second-number"));
        private IWebElement AddButtonElement => _webDriver.FindElement(By.Id("add-button"));
        private IWebElement ResultElement => _webDriver.FindElement(By.Id("result"));
        private IWebElement ResetButtonElement => _webDriver.FindElement(By.Id("reset-button"));

        public void EnterFirstNumber(string number)
        {
            FirstNumberElement.Clear();
            FirstNumberElement.SendKeys(number);
        }

        public void EnterSecondNumber(string number)
        {
            SecondNumberElement.Clear();
            SecondNumberElement.SendKeys(number);
        }

        public void ClickAdd()
        {
            AddButtonElement.Click();
        }

        public void EnsureCalculatorIsOpenAndReset()
        {
            if(_webDriver.Url != CalculatorURL)
            {
                _webDriver.Url = CalculatorURL;
            }
            else
            {
                ResetButtonElement.Click();
                WaitForEmptyResult();
            }

        }

        public string WaitForNonEmptyResult()
        {
            return WaitUntil(
                    () => ResultElement.GetAttribute("value"),
                    result => !string.IsNullOrEmpty(result));
        }

        public string WaitForEmptyResult()
        {
            return WaitUntil(
                     () => ResultElement.GetAttribute("value"),
                     result => result == string.Empty);
        }

        private T WaitUntil<T>(Func<T> getResult, Func<T, bool> isResultAccepted) where T : class
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(DefaultWaitInSeconds));
            return wait.Until(driver =>
            {
                var result = getResult();
                if (!isResultAccepted(result))
                {
                    return default;
                }
                return result;
            });
        }
    }
}
