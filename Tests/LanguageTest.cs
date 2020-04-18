using baigiamasis.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace baigiamasis.Tests
{
    public class LanguageTest : BaseTest
    {
        private LanguagePage languagePage;
        [SetUp]
        public void InitPages()
        {

            loginPage = new LoginPage(Driver);
            homePage = new HomePage(Driver);
            languagePage = new LanguagePage(Driver);
        }

        [Test]

        public void TestLanguage()
        {
            languagePage.ClickENbutton();
            languagePage.AssertENbutton();
            Thread.Sleep(3000);
            languagePage.ClickRUbutton();
            languagePage.AssertRUbutton();
            Thread.Sleep(3000);
            languagePage.ClickLTbutton();
            languagePage.AssertLTbutton();
            Thread.Sleep(3000);

          


        }



    }
}
