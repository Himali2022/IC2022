using IC2022.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using IC2022.Utilities;

namespace IC2022.Tests
{
    [TextFixture]
    public class TMTests : CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            new ChromeDriver();

            //login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }
        [Test]
        public void CreateTM_Test()
        { 
            //TM Page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);

        }
        [Test]
        public void EditTM_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);

        }

        [Test]
        public void DeleteTM_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);

        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

        
        
        
        
        
        
        
        
        
       
        

        

        

        

        
    }
}
