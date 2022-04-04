using NUnit.Framework;
using SeleniumSetUu.Pages;

namespace SeleniumSetUu.Test_Scenarios.HomePageScenario
{
    public class HomePagePositiveCases
    {
        [SetUp]
        public void Initialize()
        {
            var actions = new Actions();
            actions.InitializeDriver();
        }

        [Test]
        public void LogoutTest()
        {
            var loginPage = new LoginPage();
            var homePage = new HomePage();
            loginPage.LoginByValidCredentials();
            homePage.Logout();

            Assert.True(loginPage.SubmitButton.Displayed);
        }

        [Test]
        public void AddItemToCartFromHomePageTest()
        {
            var loginPage = new LoginPage();
            var homePage = new HomePage();
            var cartPage = new CartPage();
            loginPage.LoginByValidCredentials();
            homePage.ClickOnAddToCartButton();

            Assert.True(homePage.CartIcone.Displayed);
            homePage.ClickOnCartButton();
            Assert.True(cartPage.InventoryItemName.Displayed);
        }

        [Test]
        public void RemoveItemFromCartFromHomePageTest()
        {
            var loginPage = new LoginPage();
            var homePage = new HomePage();
            loginPage.LoginByValidCredentials();
            homePage.ClickOnAddToCartButton();
            homePage.ClickOnRemoveFromCartButton();

            Assert.True(homePage.AddToCartButton.Displayed);
        }

        [Test]
        public void SwitchFilterFromZToATest()
        {
            var loginPage = new LoginPage();
            var homePage = new HomePage();
            loginPage.LoginByValidCredentials();
            homePage.ClickOnZToAButton();

            Assert.AreEqual(Config.ItemsText.tShirtText, homePage.GetFirstItemFromTheOrder().Text);
        }

        [TearDown]
        public void CleanUp()
        {
            var actions = new Actions();
            actions.DriverQuit();
        }
    }
}
