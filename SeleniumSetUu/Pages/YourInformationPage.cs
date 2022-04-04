using OpenQA.Selenium;

namespace SeleniumSetUu.Pages
{
    public class YourInformationPage : DriverHelper
    {
        public IWebElement FirstNameField => Driver.FindElement(By.Id("first-name"));
        public IWebElement LastNameField => Driver.FindElement(By.Id("last-name"));
        public IWebElement PostalCodeField => Driver.FindElement(By.Id("postal-code"));
        public IWebElement ContinueButton => Driver.FindElement(By.Id("continue"));

        public void SetCheckoutData(string firstName, string lastName, string postalCode)
        {
            FirstNameField.SendKeys(firstName);
            LastNameField.SendKeys(lastName);
            PostalCodeField.SendKeys(postalCode);
        }

        public void ClickOnContinueButton()
        {
            ContinueButton.Click();
        }
    }
}
