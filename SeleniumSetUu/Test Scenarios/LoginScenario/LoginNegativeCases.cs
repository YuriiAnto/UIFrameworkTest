using NUnit.Framework;
using SeleniumSetUu.Pages;

namespace SeleniumSetUu.Test_Scenarios
{
    public class LoginNegativeCases
    {
        [OneTimeSetUp]
        public static void Initialize()
        {
            var actions = new Actions();
            actions.InitializeDriver();
        }

        [Test]
        public void InvalidUsernameAndValidPasswordTest ()
        {
            var loginPage = new LoginPage();
            loginPage.SetLoginData(Config.Credentials.InvalidData.invalidUsername,
                Config.Credentials.ValidData.validPassword);
            loginPage.ClickOnLoginButton();

            Assert.AreEqual(Config.ErrorsText.doNotMutchMessage, loginPage.GetErrorMessage());
        }

        [Test]
        public void ValidUsernameAndInvalidPasswordTest()
        {
            var loginPage = new LoginPage();
            loginPage.SetLoginData(Config.Credentials.ValidData.username,
                Config.Credentials.InvalidData.invalidPassword);
            loginPage.ClickOnLoginButton();

            Assert.AreEqual(Config.ErrorsText.doNotMutchMessage, loginPage.GetErrorMessage());
        }

        [Test]
        public void LockedOutUserTest()
        {
            var loginPage = new LoginPage();
            loginPage.SetLoginData(Config.Credentials.InvalidData.lockedOutUser,
                Config.Credentials.ValidData.validPassword);
            loginPage.ClickOnLoginButton();

            Assert.AreEqual(Config.ErrorsText.hasBeenLockedMessage, loginPage.GetErrorMessage());
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            var actions = new Actions();
            actions.DriverQuit();
        }

    }
}
