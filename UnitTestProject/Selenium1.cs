﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Interactions;
using System.IO;

namespace SeleniumTestProject1
{
    [TestClass]
    public class Selenium1
    {
        private string baseURL = "http://employeedetailsclient.azurewebsites.net/";
        private RemoteWebDriver driver;
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("Selenium")]
        [Priority(1)]
        [Owner("Chrome")]

        public void Create()
        {
            //IWebDriver driver = new ChromeDriver(@"C:\Users\Priyanka\Source\Workspaces\EmployeeProjectwithJenkins\EmployeeProjectwithJenkins\SeleniumTestProject1\bin\Debug");
            // driver = new InternetExplorerDriver();//open chrome
             driver = new ChromeDriver();//open chrome

            driver.Manage().Window.Maximize();//maximize the window
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));//wait for the page to load

            driver.Navigate().GoToUrl(this.baseURL);//go to url

            driver.FindElement(By.LinkText("Create New Employee")).Click();//click create button in index page

            IWebElement query = driver.FindElement(By.Name("EmpName"));//emp field
            query.SendKeys("Emp");//write text in EmpName text box
            //query.SendKeys(Keys.Tab);

            IWebElement query1 = driver.FindElement(By.Name("DeptName"));//dept field
            query1.SendKeys("");//write text in DeptName text box

            IWebElement query2 = driver.FindElement(By.Name("Designation"));//designation field
            query2.SendKeys("Desig");//write text in Designation text box

            IWebElement query3 = driver.FindElement(By.Name("Salary"));//salary field
            query3.Clear();//clear slary text box
            query3.SendKeys("2");//write text in salary text box

            query3.SendKeys(Keys.Tab);//move to create button
            query3.SendKeys(Keys.Enter);//press create button

            Assert.IsNull(query1, "Designation field cannot be empty");//designation field cannot be empty

            if (query1==null)
            {
                System.IO.File.WriteAllText(@"D:\testresult_temp\test.txt", "text");
            }


        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            //  driver.Quit();
        }



        [TestInitialize()]
        public void MyTestInitialize()
        {
        }
    }
}
