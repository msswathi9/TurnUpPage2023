using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUppage2023.Utilities;

namespace TurnUppage2023.Pages
{
    public class Homepage
    {
        public void GotoTMpage(IWebDriver driver)
        {
            //Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a", 5);
            //Identify Administration and click
            IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administration.Click();
            Thread.Sleep(2000);

            //Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);

            //Identify time and material, and click
      
            IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterial.Click();
            Thread.Sleep(2000);
        }
        public void GotoEmployeepage(IWebDriver driver) 
        {
            //Identify Administration and click
          
            IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administration.Click();
            Thread.Sleep(2000);


            //Identify Employee, and click
         
            IWebElement employee = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employee.Click();
            Thread.Sleep(2000);
        }
    }
}

