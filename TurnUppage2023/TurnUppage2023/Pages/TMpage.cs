﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IcTurnUpFeb2023.Pages
{
    public class TMpage
    {
        public void CreatTM(IWebDriver driver)
        {


            //Creat a new record for Time

            //Identify Creat new button and click
            IWebElement CreatNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            CreatNewButton.Click();
            Thread.Sleep(2000);

            //Identify Type code dropdown and Select Time
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCode.Click();
            Thread.Sleep(1500);

            IWebElement Time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            Time.Click();
            //Identify Code Text box and Enter code
            IWebElement CodeTextBox = driver.FindElement(By.Id("Code"));
            CodeTextBox.SendKeys("February2023");

            //Identify Description Text box and enter Discription
            IWebElement DescriptionTextBox = driver.FindElement(By.Id("Description"));
            DescriptionTextBox.SendKeys("Wednesday");
            Thread.Sleep(1500);


            //Identify Price per unit and enter Price per unit
            IWebElement pricePerUnitTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnitTextBox.SendKeys("25");
            Thread.Sleep(2000);

            //Identify Save button and Click
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(2000);

            //Check If New Time recored created

            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(4000);

            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            lastRecord.Click();
            Thread.Sleep(6000);


            if (lastRecord.Text == "February2023")
            {
                Console.WriteLine("New Recored Created Successfully!");
            }
            else
            {
                Console.WriteLine("Record Has Not been Created!");
            }

        }

        public void EditTm(IWebDriver driver)
        {

            //Identify Edit button and Click Edit 

            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            EditButton.Click();
            Thread.Sleep(3000);

            //Edit Code Text Box And enetr New Coad
            IWebElement editCodeTextBox = driver.FindElement(By.Id("Code"));
            editCodeTextBox.Clear();
            editCodeTextBox.SendKeys("March2023");
            Thread.Sleep(2000);

            //Edit Description Text Box and enter New Description

            IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
            editDescriptionTextBox.Clear();
            editDescriptionTextBox.SendKeys("Monday");
            Thread.Sleep(2000);

            //Edit Price Per Unit Text box and enter New Price

            IWebElement editPricePerUnitTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span"));
            editPricePerUnitTextBox.Click();
            IWebElement newPrice = driver.FindElement(By.Id("Price"));
            newPrice.Clear();
            editPricePerUnitTextBox.Click();
            newPrice.SendKeys("20");
            Thread.Sleep(2000);

            //Identify Save Button and Click

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(6000);

            IWebElement lastPageButton1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton1.Click();
            Thread.Sleep(4000);


            IWebElement lastRecord1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            lastRecord1.Click();
            Thread.Sleep(6000);

            IWebElement lastPageButton2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton2.Click();
            Thread.Sleep(4000);

            if (lastRecord1.Text == "March2023")
            {
                Console.WriteLine("Record Edited Successfully!");
            }
            else
            {
                Console.WriteLine("Record has not been Edited!");
            }
            Thread.Sleep(2000);
        }

        public void DeleteTM(IWebDriver driver)
        {

            //Navigate to Last Time Record and Identify Delete Button

            IWebElement lastTimeRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastTimeRecord.Click();
            Thread.Sleep(2000);

            //Identify Delete button, Click on Delete Button

            IWebElement lastRecoredDeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            lastRecoredDeleteButton.Click();
            Thread.Sleep(2000);


            //Capture alter pop up message and Accept

            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(4000);

            IWebElement deletedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            //Check if Time Recored Deleted 

            if (deletedRecord.Text != "March2023!")
            {

                Console.WriteLine("Recored Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Recored has not been Deleted!");
            }
        }

    }
}