using NUnit.Framework;
using OpenQA.Selenium;
using System.Security.Policy;

namespace IC2022.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver.driver)

        {   //click on Create New button
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
            //Tread.Sleep(2000);

            Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]div/[4]/a[4]/span", 5);


            //cheak if new time record has been created successfully
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]div/[4]/a[4]/span"));
            gotoLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid'/div[3]/table/tbody/tr[last]/td[1]"));
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid'/div[3]/table/tbody/tr[last]/td[3]"));
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid'/div[3]/table/tbody/tr[last]/td[4]"));

            Assert.That(newCode.Text == "November2022","Actual code and expected code do not match");
            Assert.That(newDescription.Text == "November2022", "Actual description and expected description do not match");
            Assert.That(newPrice.Text == "$12.00", "Actual price and expected price do not match");
        }

        public void TMPage.EditTM();

        {   //clik on Edit button
            IWebElement editButton = driver.FindElement(By.XPath(//*[@id="tmsGrid"]/div[3]/table/tbody/tr[1]/td[5]/a[1]));
            editButton.Click();

            //select type in the type code dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath(//*[@id="TimeMaterialEditForm"]/div/div[1]/div/span[1]/span/span[2]/span));
            typeCodeDropdown.Click();

            IWebElement timeOption = driver.FindElement(By.XPath(//*[@id="TimeMaterialEditForm"]/div/div[1]/div/span[1]/span/span[1]));
            tmOption.Click();

            //edit code in the code text box
            IWebElement codeTextbox = driver.FindElement(By.XPath(//*[@id="tmsGrid"]/div[3]/table/tbody/tr[1]/td[1]));
            codeTextBox.Clear();
            codeTextBox.SendKeys("ABC");

            //cheak if time record edited successfully
            IWebElement gotoFirstPageButton = driver.FindElement(By.XPath(//*[@id="tmsGrid"]/div[4]/ul/li[1]/span));
            gotoFirstPageButton.Click();

            IWebElement codeTextbox = driver.FindElement(By.XPath(//*[@id="tmsGrid"]/div[3]/table/tbody/tr[1]/td[1]));)
            Assert.That(codeTextBox.Text == "ABC", "Actual code and expected code do not match");

        public void TMPage.DeleteTM();

        {   //click on delete button
            IWebElement deleteButton = driver.FindElement(By.XPath(//*[@id="tmsGrid"]/div[3]/table/tbody/tr[1]/td[5]/a[2]));
            deleteButton.Click();

            //check if time record deleted successfully
            IWebElement firstCode = driver.FindElement(By.XPath("//*[@id='tmsGrid'/div[3]/table/tbody/tr[last]/td[1]"));
            IWebElement firstDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid'/div[3]/table/tbody/tr[last]/td[3]"));
            IWebElement firstPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid'/div[3]/table/tbody/tr[last]/td[4]"));

            Assert.That(firstCode,firstdDescription,firstPrice = "null",Actual code,description,price clear or not");

        }

    }
   
} 


