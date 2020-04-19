using baigiamasis.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace baigiamasis.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        private IWebElement loginButtonElement => Driver.FindElement(By.CssSelector(".line:nth-child(3) > a"));
        private IWebElement loginEmailElement => Driver.FindElement(By.Id("login_email"));
        private IWebElement passwordElement => Driver.FindElement(By.Id("login_password"));
        private IWebElement submitLoginButtonElement => Driver.FindElement(By.XPath("//button[@type='submit']"));


      


        public void ClickLoginbuttonElement()
        {
            loginButtonElement.Click();
        }

        public void EnterUserEmail(string usermail)
        {
            loginEmailElement.Clear();
            loginEmailElement.SendKeys(usermail);
        }
        public void EnterPassword(string password)
        {
            passwordElement.Clear();
            passwordElement.SendKeys(password);

        }


        public void ClickSubmitLoginButton()
        {
            submitLoginButtonElement.Click();
        }
       
        public void Login(User user)
        {
            loginButtonElement.Click();
            Thread.Sleep(2000);
            EnterUserEmail(user.UserEmail);
            EnterPassword(user.Password);
            submitLoginButtonElement.Click();
            Thread.Sleep(2000);



        }
        public void AssertLoginButtonIsVisible()
        {
            Assert.IsTrue(loginButtonElement.Displayed);
        }

    }   
    }
