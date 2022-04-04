using NUnit.Framework;
using SeleniumSetUu.Pages;

namespace SeleniumSetUu.Test_Scenarios
{
    internal class LoginPositiveCases
    {
        [OneTimeSetUp]
        public static void Initialize()
        {
            var actions = new Actions();
            actions.InitializeDriver();

        }

        [Test]
        public void ValidUsernameAndValidPasswordTest()
        {

            var loginPage = new LoginPage();
            var homePage = new HomePage();
            loginPage.SetLoginData(Config.Credentials.ValidData.username,
                Config.Credentials.ValidData.validPassword);
            loginPage.ClickOnLoginButton();

            Assert.True(homePage.BurgerMenu.Displayed);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            var actions = new Actions();
            actions.DriverQuit();
        }

    }
}
