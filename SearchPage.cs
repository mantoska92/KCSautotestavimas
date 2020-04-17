using NUnit.Framework;
using baigiamasis.Tests;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace baigiamasis.Pages
{
   public class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver) { }

        private IWebElement detailSearchElement => Driver.FindElement(By.Id("detail_search_link"));
        private IWebElement carMakeElement => Driver.FindElement(By.Name("make_id[]"));
        private IWebElement chosenMake => Driver.FindElement(By.LinkText("BMW"));
        private IWebElement carModelElement => Driver.FindElement(By.Name("model_id[]"));
        private IWebElement chosenModel => Driver.FindElement(By.CssSelector(".open .category-dropdown-item:nth-child(39) > a"));
        private IWebElement submitSearchElement => Driver.FindElement(By.CssSelector(".detail-rezult-saveButtons:nth-child(5) > .showSearchRezult"));

        
      
        public void ClickDetailSearchElement()
        {
            detailSearchElement.Click();
        }
        
        public void ClickCarMakeElement()
        {
            carMakeElement.Click();
        }
        public void ClickChosenMakelElement()
        {
            chosenMake.Click();
        }
        public void ClickCarModelElement()
        {
            carModelElement.Click();
        }
        public void ClickChosenModelElement()
        {
            chosenModel.Click();
        }
        public void ClickSubmitSearch()
        {
            submitSearchElement.Click();
            
        }

       public void AssertCarMakeElement()
        {
            Assert.IsNotNull(chosenMake);
        }

        
        
        
       
    }
}
