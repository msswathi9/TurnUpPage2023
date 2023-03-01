
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using IcTurnUpFeb2023.Pages;

//Open Chrome Browser
IWebDriver driver = new ChromeDriver();

//Login Page object initialization and defination
Loginpage logInPageobj = new Loginpage();
logInPageobj.liginactions(driver);

//Home page object initialization and defination
Homepage homePageobj = new Homepage();
homePageobj.GotoTMpage(driver);

//TM page object initialization and defination
TMpage tmPageobj = new TMpage();
tmPageobj.CreatTM(driver);

//Edit tm
tmPageobj.EditTm(driver);

//Delete Tm
tmPageobj.DeleteTM(driver);