using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Globalization;
using TechTalk.SpecFlow;
using TurnUppage2023.Pages;
using TurnUppage2023.Utilities;

namespace TurnUppage2023.Stepdefination
{
    [Binding]
    public class TMfeatureStepDefinitions : CommonDriver
    {
        Loginpage logInPageobj = new Loginpage();
        Homepage homePageobj = new Homepage();
        TMpage tmPageobj = new TMpage();

        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            //Open Chrome browser
            driver = new ChromeDriver();

            // Login Page object initialization and defination      

            logInPageobj.loginactions(driver);
        }


        [When(@"I navigated to time and material page")]
        public void WhenINavigatedToTimeAndMaterialPage()
        {
            //Home page object initialization and defination

            homePageobj.GotoTMpage(driver);

        }

        [When(@"I created time and material record")]
        public void WhenICreatedTimeAndMaterialRecord()
        {

            tmPageobj.CreateTM(driver);

        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tmPageobj.GetCode(driver);
            string newDescription = tmPageobj.GetDescription(driver);
            string newPrice = tmPageobj.GetPrice(driver);

            Assert.That(newCode == "February2023", "Actual code and expected code do not match");
            Assert.That(newDescription == "Wednesday", "Actual description and expected description do not match");
            Assert.That(newPrice == "$25.00", "Actual price and expected price do not match");
        }

        //[When(@"I update '([^']*)' on an existing time and material record")]
        //public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string Description)
        //    tmPageobj.EditTm(driver, Description);
       // }

       // [Then(@"The record should have the updated '([^']*)'")]
        //public void ThenTheRecordShouldHaveTheUpdated(string Description)
        //{
           // string editedDescription = tmPageobj.GetDescription(driver);

            //Assert.That(editedDescription == Description,"Actual description and expected description do not match");
       // }
        [When(@"I update '([^']*)','([^']*)', '([^']*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string Description, string Code, string Price)
        {
            tmPageobj.EditTm(driver, Description, Code, Price);
        }
        [Then(@"The record should have the updated '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string Description, string Code, string Price)
        {
            string EditedDescription = tmPageobj.GetDescription(driver);
            string EditedCode = tmPageobj.GetEditedCode(driver);
            string EditedPrice = tmPageobj.GetEditedPrice(driver);

            Assert.That(EditedDescription == Description, "Actual description and edited description do not match");
            Assert.That(EditedCode == Code, "Actual code and edited code do not match");
            Assert.That(EditedPrice == Price, "Actual price and edited price do not match");

        }


    }

}