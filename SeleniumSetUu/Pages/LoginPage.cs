using OpenQA.Selenium;

namespace SeleniumSetUu.Pages
{
    public class LoginPage : DriverHelper
    {
        public IWebElement UsernameField => Driver.FindElement(By.Id("user-name"));
        public IWebElement UserPassword => Driver.FindElement(By.Id("password"));
        public IWebElement SubmitButton => Driver.FindElement(By.Id("login-button"));
        public IWebElement ErrorMessage => Driver.FindElement(By.XPath("//*[@id=\"login_button_container\"]/div/form/div[3]/h3"));


        public void SetLoginData(string username, string password)
        {
            UsernameField.Click();
            UsernameField.Clear();
            UsernameField.SendKeys(username);
            UserPassword.Click();
            UserPassword.Clear();
            UserPassword.SendKeys(password);
        }

        public void ClickOnLoginButton()
        {
            SubmitButton.Click();
        }

        public string GetErrorMessage()
        {
            return ErrorMessage.Text.ToString();
        }

        public void LoginByValidCredentials() 
        {
            SetLoginData(Config.Credentials.ValidData.username,
                Config.Credentials.ValidData.validPassword);
            ClickOnLoginButton();
        }
    }
}
