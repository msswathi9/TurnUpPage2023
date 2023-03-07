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
    [Parallelizable]
    public class TM_tests: CommonDriver
    {
        //TM page object initialization and defination
        Homepage homePageobj = new Homepage();
        TMpage tmPageobj = new TMpage();

    [Test,Order(1), Description("Check if user is able to creat new record")]
        public void createTMTest() 
        {
            //Home page object initialization and defination
           
            homePageobj.GotoTMpage(driver);
            tmPageobj.CreateTM(driver);

        }
    [Test,Order(2), Description("Check if user is able to edit the existing record")]
        public void EditTMTest() 
        {
            //Edit tm

            homePageobj.GotoTMpage(driver);
            tmPageobj.EditTm(driver);
        }
    [Test, Order(3), Description("Check if user able to to delete the exisiting record")]
        public void DeleteTMTest() 
        {
            //Delete Tm

            homePageobj.GotoTMpage(driver);
            tmPageobj.DeleteTm(driver);
        }
        
    }
}
