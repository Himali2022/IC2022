using System;
using TechTalk.SpecFlow;

namespace IC2022.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions : CommonDriver
    {
        [Given(@"I looged into Turnup portal successfully")]
        public void GivenILoogedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [When(@"I navigate to time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new Time and Material Record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            //TM Page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Then(@"The record should be created successfully\.")]
        public void ThenTheRecordShouldBeCreatedSuccessfully_()
        {
            TMPage tmPageObj = new TMPage();

            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);

            Assert.That(newCode == "November2022", "Actual code and expected code do not match");
            Assert.That(newDescription == "November2022", "Actual description and expected description do not match");
            Assert.That(newPrice == "$12.00", "Actual price and expected price do not match");
        }

        [When(@"I update'([^']*)'on an existing time record")]
        public void WhenIUpdateonAnExistingTimeRecord(string Description)
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }

        [Then(@"The record should have been updated'([^']*)'")]
        public void ThenTheRecordShouldHaveBeenUpdated(string Description)
        {
            TMPage tmPageObj = new TMPage();
            string editDescription = tmPageObj.(GetEditedDescription(driver);

            Assert.That(editDescription == Description, "Actual description and expected description do not match");
        }


    }
}
