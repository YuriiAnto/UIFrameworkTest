using OpenQA.Selenium.Chrome;

namespace SeleniumSetUu
{
    public class Actions : DriverHelper
    {
        public void InitializeDriver()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Config.baseUrl);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void DriverQuit()
        {
            //var driverHelper = new DriverHelper();
            //Driver = new ChromeDriver();
            Driver.Quit();
        }

        //public static void MakeScreenshot()
        //{
        //    //Driver.driver = new ChromeDriver();
        //    string screenshotsDirectory = Directory.GetCurrentDirectory() + @"\screenshots"; //create directory for images
        //    Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot(); // make screenshot

        //    if (true) // if folder not created then create it
        //    {
        //        Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshots");
        //    }

        //    // save image  to specified directory
        //    screenshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshots\screenshot.png", ScreenshotImageFormat.Png);
        //}
    }
}
