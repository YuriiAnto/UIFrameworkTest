using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumSetUu.Pages
{
    public class HomePage : DriverHelper
    {
        public IWebElement CartElement => Driver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a"));
        public IWebElement BurgerMenu => Driver.FindElement(By.Id("react-burger-menu-btn"));
        public IWebElement LogoutLink => Driver.FindElement(By.Id("logout_sidebar_link"));
        public IWebElement Filter => Driver.FindElement(By.CssSelector("#header_container > div.header_secondary_container > div.right_component > span > select"));
        public IWebElement AddToCartButton => Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement RemoveFromCartButton => Driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public IWebElement CartIcone => Driver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a/span"));
        public ICollection<IWebElement> InventoryItems => Driver.FindElements(By.ClassName("inventory_item_name"));


        public void Logout()
        {
            BurgerMenu.Click();
            LogoutLink.Click();
        }

        public void ClickOnAddToCartButton()
        {
            AddToCartButton.Click();
        }

        public void ClickOnRemoveFromCartButton()
        {
            RemoveFromCartButton.Click();
        }

        public void ClickOnCartButton()
        {
            CartElement.Click();
        }

        public void ClickOnFilterButton()
        {
            Filter.Click();
        }

        public void ClickOnZToAButton()
        {
            SelectElement filter = new SelectElement(Filter);
            filter.SelectByValue("za");
        }

        public IWebElement GetFirstItemFromTheOrder()
        {
            return InventoryItems.FirstOrDefault();
        }
    }

    
}
