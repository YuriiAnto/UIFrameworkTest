using NUnit.Framework;
using SeleniumSetUu.Pages;

namespace SeleniumSetUu.Test_Scenarios.CartScenario
{
    public class CartPagePositiveCases
    {
        [SetUp]
        public void Initialize()
        {
            var actions = new Actions();
            actions.InitializeDriver();
        }

        [Test]
        public void ContinueShopingTest()
        {
            var loginPage = new LoginPage();
            var homePage = new HomePage();
            var cartPage = new CartPage();
            loginPage.LoginByValidCredentials();
            homePage.ClickOnCartButton();
            cartPage.ClickOnContinueShoppingButton();

            Assert.True(homePage.Filter.Displayed);
        }

        [Test]
        public void RemoveItemFromCartPageTest()
        {
            var loginPage = new LoginPage();
            var homePage = new HomePage();
            var cartPage = new CartPage();
            loginPage.LoginByValidCredentials();
            homePage.ClickOnAddToCartButton();
            homePage.ClickOnCartButton();

            Assert.True(cartPage.InventoryItemName.Displayed);
            homePage.ClickOnRemoveFromCartButton();
            cartPage.ClickOnContinueShoppingButton();
            Assert.True(homePage.AddToCartButton.Displayed);
        }

        [Test]
        public void CheckoutAnOrderTest()
        {
            var loginPage = new LoginPage();
            var homePage = new HomePage();
            var cartPage = new CartPage();
            var yourInformationPage = new YourInformationPage();
            var overviewPage = new OverviewPage();
            loginPage.LoginByValidCredentials();
            homePage.ClickOnAddToCartButton();
            homePage.ClickOnCartButton();
            cartPage.ClickOnCheckoutButton();
            yourInformationPage.SetCheckoutData(Config.CheckoutData.firstName, Config.CheckoutData.lastName, Config.CheckoutData.postalCode);
            yourInformationPage.ClickOnContinueButton();
            overviewPage.ClickOnFinishButton();

            Assert.True(overviewPage.ThanksForOrderText.Displayed);
        }

        [TearDown]
        public void CleanUp()
        {
            var actions = new Actions();
            actions.DriverQuit();
        }
    }
}
