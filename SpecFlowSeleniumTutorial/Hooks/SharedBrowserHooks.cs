using BoDi;
using SpecFlowSeleniumTutorial.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumTutorial.Hooks
{
    [Binding]
    public class SharedBrowserHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun(ObjectContainer testThreadContainer)
        {
            testThreadContainer.BaseContainer.Resolve<BrowserDriver>();
        }
    }
}
