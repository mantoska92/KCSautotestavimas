using baigiamasis.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace baigiamasis.Tests
{
   public class SearchTest : BaseTest
    {
        
        private SearchPage searchPage;

        [SetUp]
        public void InitPages()
        {
            loginPage = new LoginPage(Driver);
            homePage = new HomePage(Driver);
            searchPage = new SearchPage(Driver);
            
        }
        [Test]

        public void SearchingTest()
        {
            searchPage.ClickDetailSearchElement();
            searchPage.ClickCarMakeElement();
            searchPage.ClickChosenMakelElement();
            searchPage.ClickCarModelElement();
            searchPage.ClickChosenModelElement();
            searchPage.ClickSubmitSearch();

            searchPage.AssertCarMakeElement();
        }
    }
}
