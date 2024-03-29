﻿


using OpenQA.Selenium.Internal;
using System.Security.Cryptography.X509Certificates;

namespace IC2022.Pages
{
    public class TMPage : CommonDriver
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
            timeOption.Click();

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
            Thread.Sleep(2000);
            
        }
        public string GetCode(IWebDriver driver)
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid'/div[3]/table/tbody/tr[last]/td[1]"));
            return actualCode.Text;
        public string GetDescription(IWebDriver driver)
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid'/div[3]/table/tbody/tr[last]/td[3]"));
            return actualDescription.Text;
        public string GetPrice(IWebDriver driver)
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid'/div[3]/table/tbody/tr[last]/td[4]"));
            return actualPrice.Text;

      
        public void TMPage.EditTM(IWebDriver.driver, string Description)

        {   
            Thread.Sleep(4000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement findNewRecordCreated = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findNewRecordCreated.Text == "November2022")
            {
                Thread.Sleep(2000);
                // click edit button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");
            }

            // edit code textbox 
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("C001");
            Thread.Sleep(1500);

            // edit description textbox
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys(Description);
            Thread.Sleep(1500);

            // edit price per unit textbox
            IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement pricePerUnitTextbox = driver.FindElement(By.Id("Price"));

            overlappingTag.Click();
            pricePerUnitTextbox.Clear();
            overlappingTag.Click();
            pricePerUnitTextbox.SendKeys("300");

            // click save button
            IWebElement clickSavebutton = driver.FindElement(By.Id("SaveButton"));
            clickSavebutton.Click();
            Thread.Sleep(1500);

            // click go to the late page
            IWebElement gotothelastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotothelastpageButton.Click();
            Thread.Sleep(1500);


        public string GetEditedDescription(IWebDriver driver) 
        {
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid'/div[3]/table/tbody/tr[last]/td[3]"));
            return editedDescription.Text;
        }
            
        public void TMPage.DeleteTM(IWebDriver.driver)

        {
            Thread.Sleep(3000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            // click delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(2000);

            // conforming delete ok button
            driver.SwitchTo().Alert().Accept();

        }

    }
   
} 


