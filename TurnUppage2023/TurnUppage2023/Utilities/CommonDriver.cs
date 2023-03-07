using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUppage2023.Pages;

namespace TurnUppage2023.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
    [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();

            // Login Page object initialization and defination
            Loginpage logInPageobj = new Loginpage();
            logInPageobj.loginactions(driver);

        }
    [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
