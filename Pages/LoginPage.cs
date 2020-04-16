using baigiamasis.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

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
            loginEmailElement.SendKeys(usermail);
        }
        public void EnterPassword(string password)
        {
            passwordElement.SendKeys(password);

        }
        public void ClickSubmitLoginButton()
        {
            submitLoginButtonElement.Click();
        }
        public void AssertLoginButtonIsVisible()
        {
            Assert.IsTrue(submitLoginButtonElement.Displayed);
        }
        public void Login(User user)
        {
            EnterUserEmail(user.UserEmail); ;
            EnterPassword(user.Password);
        }
    }   
    }
