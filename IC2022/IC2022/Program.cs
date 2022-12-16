using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


        // open chrome browser
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        // launch turnup portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        Thread.Sleep(1000);

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
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));


if(helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfully.test passed.");
}
else
{
    Console.WriteLine("Login failed,test failled."); 
}



//navigate to Time and Material
IWebElement administrationDropdown = driver.FindElement(By.XPath("//*[@id=/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();
Thread.Sleep(500);

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

//click on Create New button
Thread.Sleep(1500);
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
createNewButton.Click();
Thread.Sleep(500);

//select Time in the typecode dropdown
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]span"));
typeCodeDropdown.Click();

IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
tmOption.Click();

//enter code in the code textbox
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("November2022");

//enter description inthe description textbox
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("November2022");

//enter price in price per unit textbox
IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id='timeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
overlappingTag.Click();

IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
priceTextbox.SendKeys("12");

//click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();

//cheak if new time record has been created successfully
IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]div/[4]/a[4]/span"));
gotoLastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid'/div[3]/table/tbody/tr[last]/td[1]"));

if(newCode.Text == "November2022")
{
    Console.WriteLine("Time record created successfully.");
}
else
{
    Console.WriteLine("Time record hasn,t created successfully");
}





