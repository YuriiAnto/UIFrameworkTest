using OpenQA.Selenium;

namespace SeleniumSetUu.Pages
{
    public class CartPage : DriverHelper
    {
        public IWebElement InventoryItemName => Driver.FindElement(By.XPath("//*[@id=\"item_4_title_link\"]/div"));
        public IWebElement RemoveButtonOnCartPage => Driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public IWebElement ContinueShoppingButton => Driver.FindElement(By.Id("continue-shopping"));
        public IWebElement CheckoutButton => Driver.FindElement(By.Id("checkout"));
        
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
