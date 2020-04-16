using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace baigiamasis.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }
        private IWebElement logoutButtonElement => Driver.FindElement(By.CssSelector("//a[contains(text(),'Atsijungti')]"));
        private LoginPage loginPage;

        public void ClickLogout()
        {
            logoutButtonElement.Click();
        }

        public void AssertLogoutButtonIsVisible()
        {
            Assert.IsNotNull(logoutButtonElement, "User was not logged in");
        }
        public void Logout()
        {
            logoutButtonElement.Click();
            loginPage = new LoginPage(Driver);
            loginPage.AssertLoginButtonIsVisible();

        }
    }
}
