using OpenQA.Selenium;

namespace SeleniumSetUu.Pages
{
    public class CartPage : DriverHelper
    {
        public IWebElement InventoryItemName => Driver.FindElement(By.XPath("//div[text()='Sauce Labs Backpack']"));
        public IWebElement RemoveButtonOnCartPage => Driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public IWebElement ContinueShoppingButton => Driver.FindElement(By.Id("continue-shopping"));
        public IWebElement CheckoutButton => Driver.FindElement(By.XPath("//button[@name='checkout']"));
        
        public void ClickOnContinueShoppingButton()
        {
            ContinueShoppingButton.Click();
        }

        public void ClickOnCheckoutButton()
        {
            CheckoutButton.Click();
        }
    }
}
