using baigiamasis.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace baigiamasis.Tests
{
    public class UserInfoUpdateTest : BaseTest
    {
        
        

        private IWebElement myGarage => Driver.FindElement(By.CssSelector(".btn-primary"));
        private IWebElement changeName => Driver.FindElement(By.Id("userFirstname"));
        private IWebElement changePhoneNumber => Driver.FindElement(By.Id("userPhone"));
        private IWebElement changeCountry => Driver.FindElement(By.CssSelector(".col-sm-6:nth-child(1) .select .select"));
        private IWebElement chosenCountry => Driver.FindElement(By.CssSelector("dropdown-menu > .category-dropdown-item:nth-child(2) span"));
        private IWebElement changeCity => Driver.FindElement(By.CssSelector(".col-sm-6:nth-child(2) .select .select"));
        private IWebElement chosenCity => Driver.FindElement(By.CssSelector(".fake-select:nth-child(2) > .category-dropdown-item:nth-child(2) span"));
        private IWebElement submitChanges => Driver.FindElement(By.CssSelector(".information-Form-button:nth-child(4) > button-"));
        
        [SetUp]
        public void InitPages()
        {
            loginPage = new LoginPage(Driver);
            homePage = new HomePage(Driver);
        }

        [Test]

        public void UserUpdateTest()

        {
            loginPage.ClickLoginbuttonElement();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            loginPage.EnterUserEmail("testeris@testas.lt");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            loginPage.EnterPassword("slaptazodis");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            loginPage.ClickSubmitLoginButton();
            Thread.Sleep(2000);
            myGarage.Click();
            changeName.SendKeys("fake");
            changePhoneNumber.SendKeys("+3777777");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            changeCountry.Click();
            Thread.Sleep(2000);
            new SelectElement(chosenCountry).SelectByText("Estija");
            Thread.Sleep(2000);
            changeCity.Click();
            Thread.Sleep(2000);
            new SelectElement(chosenCity).SelectByText("Talinas");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            submitChanges.Click();
        }


    }
}
