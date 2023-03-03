using TurnUppage2023.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUppage2023.Utilities;
using OpenQA.Selenium;

namespace TurnUppage2023.Tests
{
    [TestFixture]
    public class TM_tests: CommonDriver
    {
        [SetUp]
        public void LoginSteps() 
        {
            driver = new ChromeDriver();

         // Login Page object initialization and defination
            Loginpage logInPageobj = new Loginpage();
            logInPageobj.loginactions(driver);

         //Home page object initialization and defination
            Homepage homePageobj = new Homepage();
            homePageobj.GotoTMpage(driver);
        }
        [Test,Order(1)]
        public void createTMTest() 
        {
         //TM page object initialization and defination
           TMpage tmPageobj = new TMpage();
           tmPageobj.CreateTM(driver);

        }
        [Test,Order(2)]
        public void EditTMTest() 
        {
            //TM page object initialization and defination
            TMpage tmPageobj = new TMpage();
            //Edit tm
            tmPageobj.EditTm(driver);
        }
        [Test, Order(3)]
         public void DeleteTMTest() 
        {
            //TM page object initialization and defination
            TMpage tmPageobj = new TMpage();
            //Delete Tm
            tmPageobj.DeleteTm(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
