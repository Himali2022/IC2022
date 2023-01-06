

namespace IC2022.Pages
{
    public class LoginPage : CommonDriver
    {
        public void LoginActions(IWebDriver, driver);
        {

            driver.Manage().Window.Maximize();

            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(1500);

            // identify username and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // identify password textbox and enter valid passward
            IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
            PasswordTextbox.SendKeys("123123");

            // click login button
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            LoginButton.Click();
        }
        

    }
}
