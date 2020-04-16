using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Allure;
using baigiamasis.Pages;

namespace baigiamasis.Tests
{
    public class BaseTest
    {
         protected IWebDriver Driver;
         protected LoginPage loginPage;
         protected HomePage homePage;

        [SetUp]
        public void InitDriver()
        {
            Driver = new ChromeDriver();
            Driver.Url = "https://www.autobilis.lt/";
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            InitPages();
        }
        public void InitPages()
        {
            loginPage = new LoginPage(Driver);
            homePage = new HomePage(Driver);
        }

        [TearDown]
        public void AfterEveryTest()
        {
            Driver.Quit();

        }

    }
    }
