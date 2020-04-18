using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace baigiamasis.Pages
{
    public class LanguagePage : BasePage
    {

        public LanguagePage(IWebDriver driver) : base(driver) { }


        private IWebElement languageEN => Driver.FindElement(By.CssSelector(".nav > li:nth-child(2) > a"));
        private IWebElement languageRU => Driver.FindElement(By.CssSelector(".languages > li:nth-child(3) > a"));
        private IWebElement languageLT => Driver.FindElement(By.CssSelector(".languages > li:nth-child(1) > a"));


        public void ClickENbutton()
        {
            languageEN.Click();
        }

        public void ClickRUbutton()
        {
            languageRU.Click();
        }

        public void ClickLTbutton()
        {
            languageLT.Click();
        }

        public void AssertENbutton()
        {
            Assert.AreEqual("https://www.autobilis.lt/en/", Driver.Url);
            IWebElement specOffer = Driver.FindElement(By.CssSelector("#get-special > span"));
            Assert.AreEqual("Spec. offer", specOffer.Text);

        }
        public void AssertRUbutton()
        {
            Assert.AreEqual("https://www.autobilis.lt/ru/", Driver.Url);
            IWebElement specOffer = Driver.FindElement(By.CssSelector("#get-special > span"));
            Assert.AreEqual("Спец. предложение", specOffer.Text);
        }

        public void AssertLTbutton()
        {
            Assert.AreEqual("https://www.autobilis.lt/", Driver.Url);
            IWebElement specOffer = Driver.FindElement(By.CssSelector("#get-special > span"));
            Assert.AreEqual("Spec. pasiūlymai", specOffer.Text);
        }



    }
}
