

namespace IC2022.Utilities
{
    public class Waits
    {
        public static void WaitForElementToBeClickable(IWebDriver driver, string locator, string locatorvalue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
        }

            if(locator == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if(Locator == "id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.id(locatorValue)));
            }
            if(Locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.id(locatorValue))); 
            }

        public static void WaitForElementToExist(IWebDriver driver, string locator, string locatorvalue, int seconds) 
        {

            if (locator == "XPath")
            { 
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue))); 
            }
            if (Locator == "id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.id(locatorValue))); 
            }
            if (Locator == "CssSelector")
            { 
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.id(locatorValue))); 
            }

        }

    }
    
}