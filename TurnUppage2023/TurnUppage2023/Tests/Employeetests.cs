using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUppage2023.Pages;
using TurnUppage2023.Utilities;

namespace TurnUppage2023.Tests

{

    [TestFixture]
    [Parallelizable]
    public class Employee_tests : CommonDriver
    {
        //Page Objects initialzation
        Homepage homePageobj = new Homepage();
        Employeepage employeeObj = new Employeepage();


        [Test, Order(1), Description("Check if user is able to creat new employee record")]
        public void CreateEmployeTests()
        {
           //Identify Createemployee object initialization and Defination

            homePageobj.GotoEmployeepage(driver);
            employeeObj.CreatEmployee(driver);
        }
        [Test, Order(2), Description("Check if user is able to edit existing employee record")]
        public void EditEmployeeTests()
        {
            //Identify Editemployee object initialization and Defination
            homePageobj.GotoEmployeepage(driver);
            employeeObj.EditEmployeerecord(driver);
        }
        [Test, Order(3), Description("Check if user is able to Delete exisiting employee new record")]
        public void DeleteEmployeeTests()
        {
            //Identify DeleteEmployee Object initialization and Defination
            homePageobj.GotoEmployeepage(driver);
            employeeObj.DeleteEmployeerecord(driver);
        } 
    }
}
