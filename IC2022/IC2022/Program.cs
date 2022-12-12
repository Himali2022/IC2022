using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


        // open chrome browser
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        // launch turnup portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

        // identify username and enter valid username
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");

        // identify password textbox and enter valid passward
        IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
        PasswordTextbox.SendKeys("123123");

        // click login button
        IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        LoginButton.Click();

//check if user has loggedin successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='LogoutFrom']/uL/Li/a"));

if(helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfully.test passed.");
}
else
{
    Console.WriteLine("Login failed,test failled."); 
}