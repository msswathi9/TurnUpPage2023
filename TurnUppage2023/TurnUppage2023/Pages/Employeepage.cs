using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TurnUppage2023.Pages
{
    public class Employeepage
    {

        public void CreatEmployee(IWebDriver driver) 
        {
            //Identify Create new button and click
            IWebElement create = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            create.Click();
            Thread.Sleep(1000);

            //Identify Name Text box, and send keys
            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("Swathi Shetty");
            Thread.Sleep(1000);

            //Identify User text box,and sendkeys
            IWebElement userTextBox = driver.FindElement(By.Id("Username"));
            userTextBox.SendKeys("Swathi");
            Thread.Sleep(1000);

            //Identify  Contact text box and Send keys.
            IWebElement contactTextBox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextBox.SendKeys("0987654321");
            Thread.Sleep(1000);
            
            //Identify Password text box and send keys
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("Abcdefgh@1");
            Thread.Sleep(2000);

            //Identify Re enter password text box and send keys
            IWebElement reEnterPasswordTextBox = driver.FindElement(By.Id("RetypePassword"));
            reEnterPasswordTextBox.SendKeys("Abcdefgh@1");

            //identify IsAdmin tick box and click
            IWebElement isAdminTickBox = driver.FindElement(By.Id("IsAdmin"));
            isAdminTickBox.Click();
            Thread.Sleep(1000);

            //Identify Vechile Text Box  and send keys
            IWebElement vechileTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vechileTextBox.SendKeys("1234");

            //Identify Group drop down and select Aussie group
            IWebElement groupDropDown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            groupDropDown.Click();
            Thread.Sleep(1000);

            IWebElement aussieGroup = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[18]"));
            aussieGroup.Click();
            Thread.Sleep(1000);
             
         
            //Identify Save button and Click
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);

            // Identify Back to list and Click
            IWebElement backToList = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToList.Click();
            Thread.Sleep(2000);

            //Identify Lastpage Button and Click
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(4000);

            //Identify last employeerecord
            IWebElement lastEmployeeRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            lastEmployeeRecord.Click();
            Thread.Sleep(4000);

            Assert.That(lastEmployeeRecord.Text == "Swathi Shetty", "Actuall record does not match with expected record");


        }
        public void EditEmployeerecord(IWebDriver driver) 
        {
            //Identify Lastpage Button and Click
            Thread.Sleep(3000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(2000);

            //Identify last employeerecord
            Thread.Sleep(3000);
            IWebElement lastEmployeerecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            lastEmployeerecord.Click();
            Thread.Sleep(1000);

           //Identify edit button and click

            if( lastEmployeerecord.Text == "Swathi Shetty")
            {
                IWebElement lastEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                lastEmployee.Click();
                Thread.Sleep(4000);
            }
            else
            {
                Assert.Fail("Record not found");
            }

            //Identify Edit Name Text box, Clear
            IWebElement editNameTextBox = driver.FindElement(By.Id("Name"));
            editNameTextBox.Clear();
            Thread.Sleep(1000);

            //Identify name text box and senkeys

            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("Swati Madham");
            Thread.Sleep(1000);

            //Identify User text box, and clear
            IWebElement userTextbox = driver.FindElement(By.Id("Username"));
            userTextbox.Clear();
            Thread.Sleep(1000);

            //Identify User text box,and Sendkeys
            IWebElement userTextBox = driver.FindElement(By.Id("Username"));
            userTextBox.SendKeys("Swati");
            Thread.Sleep(1000);

            //Identify Edit contact text box and clear

            IWebElement editContactTextBox = driver.FindElement(By.Id("ContactDisplay"));
            editContactTextBox.Clear();
            Thread.Sleep(1000);

            //Identify Contact button and Sendkeys

            IWebElement contactTextBox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextBox.SendKeys("3456789210");
            Thread.Sleep(1000);

            //Identify Edit Password text box and clear
            IWebElement editPasswordTextBox = driver.FindElement(By.Id("Password"));
            editPasswordTextBox.Clear();
            Thread.Sleep(1000);

            //Identify Password text box and send keys
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("Abcdeffh@1");
            Thread.Sleep(2000);

            //odentify Edit password text box and clear
            IWebElement editReEnterPasswordTextBox = driver.FindElement(By.Id("RetypePassword"));
            editReEnterPasswordTextBox.Clear();
            Thread.Sleep(1000);

            //Identify Re enter password text box and send keys
            IWebElement reEnterPasswordTextBox = driver.FindElement(By.Id("RetypePassword"));
            reEnterPasswordTextBox.SendKeys("Abcdeffh@1");
            Thread.Sleep(2000);

            //identify Edit vechile text box and clear
            IWebElement editVechileTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            editVechileTextBox.Clear();
            Thread.Sleep(1000);

            //Identify Vechile Text Box  and send keys
            IWebElement vechileTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vechileTextBox.SendKeys("1235");
            Thread.Sleep(1000);

            //Identify Edit Group dropdown and send keys
            IWebElement editGroupDropDown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            editGroupDropDown.Click();

            //Identify Group  and select tests
            IWebElement tests = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[79]"));
            tests.Click();
           
            Thread.Sleep(1000);

           
            //Identify Save button and Click
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);

            //Identify backtopage and click

            IWebElement backToPage = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToPage.Click();
            Thread.Sleep(2000);

            //Identify Lastpage Button and Click
            IWebElement lastPageButton1 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPageButton1.Click();
            Thread.Sleep(4000);

            //Identify last employeerecord
            IWebElement employeeRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            employeeRecord.Click();
            Thread.Sleep(4000);

            Assert.That(employeeRecord.Text == "Swati Madham", "Actually Recored and expeacted results are not same");

        }
        public void DeleteEmployeerecord(IWebDriver driver) 
        {

            //Identify Lastpage Button and Click
            Thread.Sleep(3000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(4000);

            //Identify last employeerecord
            Thread.Sleep(3000);
            IWebElement lastEmployeerecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            lastEmployeerecord.Click();

            if (lastEmployeerecord.Text == "Swati Madham")
            {
                IWebElement employeeRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                employeeRecord.Click();
                Thread.Sleep(4000);
            }
            else
            {
                Assert.Fail("recored not Found");
            }

            //Identify Delete button and click
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(1000);

            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            //Identify last deleted employeerecord
            IWebElement deletedEmployeeRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            deletedEmployeeRecord.Click();

            Assert.That(deletedEmployeeRecord.Text != "Swati Madham", "Record was not Deleted");



        }
    }
}
