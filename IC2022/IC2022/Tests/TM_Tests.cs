

namespace IC2022.Tests
{
    [TextFixture]
    [Parallelizable]
    public class TMTests : CommonDriver
    {

        [Test,Order(1), Description ("check if user is able to create a new record with valid data")]
        public void CreateTM_Test()
        {
            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            //TM Page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);

        }

        [Test,Order(2),Description("check if user is able to edit an existing record with valid data")]
        public void EditTM_Test()
        {
            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);

        }

        [Test,Order(3), Description("check if user is able to delete an existing record successfully")]
        public void DeleteTM_Test()
        {
            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

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
