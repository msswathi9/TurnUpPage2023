using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUppage2023.Utilities
{
    public class Wait
    {

        public static void WaitToBeClickable(IWebDriver driver, string locatortype, string locatorValue, int seconds)

        {
            var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locatortype == "XPath")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locatortype == "Id")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if(locatortype == "CssSelector")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
       


        }
    }
}
