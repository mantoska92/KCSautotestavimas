using baigiamasis.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            Thread.Sleep(4000); 

            searchPage.AssertCarMakeElement();
        }

        [Test]
        public void SaveSearch()
        {
            loginPage.ClickLoginbuttonElement();
            Thread.Sleep(6000);
            loginPage.EnterUserEmail("testeris@testas.lt");
            Thread.Sleep(6000);
            loginPage.EnterPassword("slaptazodis");
            Thread.Sleep(6000);
            loginPage.ClickSubmitLoginButton();
            Thread.Sleep(6000);
            searchPage.ClickDetailSearchElement();
            searchPage.ClickCarMakeElement();
            searchPage.ClickChosenMakelElement();
            searchPage.ClickCarModelElement();
            searchPage.ClickChosenModelElement();
            searchPage.ClickSaveSearchButton();
            searchPage.SavedSearchNameElement();
            Thread.Sleep(5000);
            searchPage.ClickSavedSearchSubmitButton();
            Thread.Sleep(5000);

            
        }
    }
}
