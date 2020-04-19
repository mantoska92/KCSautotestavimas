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
        private IWebElement myInformation => Driver.FindElement(By.LinkText("Mano duomenys"));
        private IWebElement changeName => Driver.FindElement(By.Id("userFirstname"));
        private IWebElement changePhoneNumber => Driver.FindElement(By.Id("userPhone"));
        private IWebElement changeCountry => Driver.FindElement(By.XPath("(//button[@type='button'])[3]"));


        private IWebElement chosenCountry => Driver.FindElement(By.CssSelector(".dropdown-menu > .category-dropdown-item:nth-child(3) span"));
        private IWebElement changeCity => Driver.FindElement(By.XPath("(//button[@type='button'])[4]"));
       
        private IWebElement chosenCity => Driver.FindElement(By.CssSelector(".fake-select:nth-child(2) > .category-dropdown-item:nth-child(2) span"));
        private IWebElement checkBoxElement => Driver.FindElement(By.Id("checkbox_newsletter"));
        private IWebElement justClickElement => Driver.FindElement(By.XPath("//body"));
        
        private IWebElement submitChanges => Driver.FindElement(By.XPath("(//button[@type='submit'])[2]"));
        
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
            Thread.Sleep(6000);
            loginPage.EnterUserEmail("testeris@testas.lt");
            Thread.Sleep(6000);
            loginPage.EnterPassword("slaptazodis");
            Thread.Sleep(6000);
            loginPage.ClickSubmitLoginButton();
            Thread.Sleep(2000);
            myGarage.Click();
            Thread.Sleep(2000);
            myInformation.Click();
            changeName.Clear();
            changeName.SendKeys("fake");
            changePhoneNumber.Clear();
            changePhoneNumber.SendKeys("+3777777");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            changeCountry.Click();
            Thread.Sleep(2000);
            chosenCountry.Click();
            Thread.Sleep(2000);
            changeCity.Click();
            Thread.Sleep(2000);
            chosenCity.Click();
            Thread.Sleep(8000);
            //checkBoxElement.Click();
            justClickElement.Click();
            Thread.Sleep(5000);
            submitChanges.Click();
            Thread.Sleep(2000);


            Assert.AreEqual("https://www.autobilis.lt/user/profile", Driver.Url);
            IWebElement success = Driver.FindElement(By.XPath("/html/body/div[9]/p"));
            Assert.AreEqual("Profilis atnaujintas sėkmingai.", success.Text);
           

          //  Assert.AreEqual("https://www.autobilis.lt/user/profile", Driver.Url);
           // IWebElement success2 = Driver.FindElement(By.CssSelector(".sa-success"));
           // Assert.AreEqual("Profilis atnaujintas sėkmingai.", success2.Text);
        }


        //body > div.sweet-alert.hideSweetAlert > h2
       // body > div.sweet-alert.hideSweetAlert > p







    }
}
