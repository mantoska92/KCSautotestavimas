using baigiamasis.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace baigiamasis.Tests
{
    class LoginTest : BaseTest

    {

        private LoginPage loginPage;
        private HomePage homePage;
        

        [SetUp]
        public void InitPages()
        {
            loginPage = new LoginPage(Driver);
            homePage = new HomePage(Driver);
        }
        [Test]
        public void TestLogin()
        {
            loginPage.ClickLoginbuttonElement();
            Thread.Sleep(6000);
            loginPage.EnterUserEmail("testeris@testas.lt");
            Thread.Sleep(6000);
            loginPage.EnterPassword("slaptazodis");
            Thread.Sleep(6000);
            loginPage.ClickSubmitLoginButton();
            Thread.Sleep(6000);
            homePage.AssertLogoutButtonIsVisible();
            Thread.Sleep(6000);
        }

        
        
        [TearDown]
        public void Logout()
        {
            homePage.ClickLogout();
            loginPage.AssertLoginButtonIsVisible();
        }
    }
}