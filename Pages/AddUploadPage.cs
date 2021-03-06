﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace baigiamasis.Pages
{
    public class AddUploadPage : BasePage
    {
        public AddUploadPage(IWebDriver driver) : base(driver) { }

        private IWebElement addAdvertElement => Driver.FindElement(By.CssSelector(".btn-danger"));
        private IWebElement chooseVehicleType => Driver.FindElement(By.CssSelector(".dropdown:nth-child(3) > .select .select"));
        private IWebElement motorcycleElement => Driver.FindElement(By.CssSelector(".dropdown-menu > .category-dropdown-item:nth-child(2) span:nth-child(2)"));
        private IWebElement motorcycleMakeElement => Driver.FindElement(By.CssSelector(".search-params-item:nth-child(1) .err-glow > input"));
        private IWebElement motorcycleMakeSelected => Driver.FindElement(By.LinkText("BMW"));
        private IWebElement motorcycleModelElement => Driver.FindElement(By.CssSelector("[placeholder='Modelis']"));
        private IWebElement motorcycleModelSelected => Driver.FindElement(By.LinkText("G 650 GS"));
        private IWebElement motorcycleMakeYear => Driver.FindElement(By.CssSelector(".col-xs-6 .err-glow > input"));
        private IWebElement motorcycleMakeMonth => Driver.FindElement(By.CssSelector(".open .category-dropdown-item:nth-child(15) span"));
        private IWebElement motorcyclePower => Driver.FindElement(By.Name("moto_power"));
        private IWebElement motorcycleMCubicCapacity => Driver.FindElement(By.Name("moto_engine_capacity_cubic"));
        private IWebElement motorcycleCubicCapacitySelected=> Driver.FindElement(By.CssSelector(".err-glow .category-dropdown-item:nth-child(14) > a"));
        private IWebElement motorcyclePrice => Driver.FindElement(By.CssSelector(".search-params-item > .err-glow"));
        private IWebElement motorcyclePriceSelected => Driver.FindElement(By.CssSelector(".search-params-item:nth-child(15) > .form-control"));
        private IWebElement agreeTermsCheckBox => Driver.FindElement(By.CssSelector(".col-sm-6 > .checkbox:nth-child(2) > label"));
        private IWebElement getNotificationsCheckBox => Driver.FindElement(By.CssSelector(".col-sm-6 > .checkbox:nth-child(3) > label"));
        private IWebElement submitAd => Driver.FindElement(By.Id("submitAdvert"));
        private IWebElement submitDesktopAd => Driver.FindElement(By.Id("submitDesktopAdvert"));


        public void ClickAddAdvertButton()
        {
            addAdvertElement.Click();
        }
        public void ClickChoseVehicleType()
        {
            chooseVehicleType.Click();
        }
        public void ClickMotorcycleElemet()
        {
            motorcycleElement.Click();
        }
        public void ClickMotorcycleMakeElement()
        {
            motorcycleMakeElement.Click();
        }
        public void ClickMotorcycleMakeSelected()
        {
            motorcycleMakeSelected.Click();
        }
        public void ClickMotorcycleModelElement()
        {
            motorcycleModelElement.Click();
        }
        public void ClickMotorcycleModelSelected()
        {
            motorcycleModelSelected.Click();
        }
        public void ClickMotorcycleMakeYear()
        {
            motorcycleMakeYear.Click();
        }
        public void ClickMotorcycleMakeMonth()
        {
            motorcycleMakeMonth.Click();
        }
        public void ChoseMotorcyclePower()
        {
            motorcyclePower.SendKeys("57");
        }
        public void ClickCubicCapacityElement()
        {
            motorcycleMCubicCapacity.Click();
        }
        public void ClickCubicCapacitySelected()
        {
            motorcycleCubicCapacitySelected.Click();
        }
        public void ClickMotorcyclePrice()
        {
            motorcyclePrice.Click();
        }
        public void ClickPriceSelected()
        {
            motorcyclePriceSelected.SendKeys("20000");
        }
        public void ClickAgreeTermsCheckBox()
        {
            agreeTermsCheckBox.Click();
        }
        public void ClickGetNotificationsCheckBox()
        {
            getNotificationsCheckBox.Click();
        }
        public void SubmitAdvert()
        {
            submitAd.Click();
        }
        public void SubmitDesktopAdvert()
        {
            submitDesktopAd.Click();
           

        }

       public void AssertAdvert()
        {
            // Assert.AreEqual("", Driver.Url);
            IWebElement success = Driver.FindElement(By.CssSelector(".advert-top-wraper > div:nth-child(1)"));
            // Assert.AreEqual("Profilis atnaujintas sėkmingai.", success.Text);
            Assert.AreEqual("BMW G 650 GS / 2007 M.\r\nPirkti papildomas paslaugas", success.GetAttribute("innerText"));
        }


    }
}
