using baigiamasis.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace baigiamasis.Tests
{
   public class Logout : BaseTest
    {

        [SetUp]
        public void Login()
        {
            new LoginPage(Driver).Login(User.DefaultUser);
        }
        [Test]
        public void TestLogout()
        {

            homePage.ClickLogout();
            loginPage.AssertLoginButtonIsVisible();
        }
    }
}
