using OpenQA.Selenium;

namespace SeleniumSetUu.Pages
{
    public class OverviewPage : DriverHelper
    {
        public IWebElement FinishButton => Driver.FindElement(By.Id("finish"));
        public IWebElement ThanksForOrderText => Driver.FindElement(By.XPath("//*[@id=\"checkout_complete_container\"]/h2"));

        public void ClickOnFinishButton()
        {
            FinishButton.Click();
        }
    }
}
