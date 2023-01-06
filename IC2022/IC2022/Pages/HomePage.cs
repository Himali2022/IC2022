


namespace IC2022.Pages
{
    public class HomePage : CommonDriver
    {
        public void GoToTMPage(IWebDriver.driver);

        {   Thread,Sleep(2000);
            //navigate to Time and Material
            IWebElement administrationDropdown = driver.FindElement(By.XPath("//*[@id=/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            Thread.Sleep(1000);

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
        public void GoToEmployeePage(IWebDriver.driver);

        { 
            //navigate to Time and Material
            IWebElement administrationDropdown = driver.FindElement(By.XPath("//*[@id=/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            Thread.Sleep(500);

            IWebElement EmployeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            employeeOption.Click();

    }
}
