using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace baigiamasis.Tests
{
  /*  public class Baigiamasis : BaseTest
    {

        IWebElement login => Driver.FindElement(By.LinkText("Prisijungti"));
        IWebElement register => Driver.FindElement(By.Id("login_register_btn"));
        IWebElement name => Driver.FindElement(By.Id("register_name"));
        IWebElement phone => Driver.FindElement(By.Id("register_tel"));
        IWebElement email => Driver.FindElement(By.Id("inputEmail"));
        IWebElement country => Driver.FindElement(By.LinkText(".country-selector > .category-dropdown-item:nth-child(1) span"));
        IWebElement city => Driver.FindElement(By.CssSelector(".city-group:nth-child(2) .category-dropdown-item:nth-child(2) span"));
        IWebElement password => Driver.FindElement(By.Id("inputPassword"));
        IWebElement passwordConfirm => Driver.FindElement(By.Id("inputPasswordConfirm"));
        IWebElement registerRules => Driver.FindElement(By.Id("register-rules"));
        IWebElement submitRegister => Driver.FindElement(By.Id("submit-regitration button"));


        [SetUp]
        public void BeforeTest()
        {
            Driver.Url = "https://www.autobilis.lt/";
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void FillForm()
        {
            login.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            register.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            name.SendKeys("Mantautas");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            phone.SendKeys("+37000000");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            email.SendKeys("tekstas@tekstas.lt");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            new SelectElement(country).SelectByText("Lietuva");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            new SelectElement(city).SelectByText("Kaunas");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            password.SendKeys("slaptazodis");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            passwordConfirm.SendKeys("slaptazodis");
            registerRules.Click();
            submitRegister.Click();
            Thread.Sleep(4000);

            Assert.AreEqual("", name.Text);
            Assert.AreEqual("", phone.Text);
            Assert.AreEqual("", email.Text);
            Assert.AreEqual("", city.Text);
            Assert.AreEqual("",password.Text);
            Assert.AreEqual("", passwordConfirm.Text);

        }

    }*/
   
}
