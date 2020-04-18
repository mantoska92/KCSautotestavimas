using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace baigiamasis.Tests
{
    public class HelpFroBussinesTest : BaseTest
    {
        private IWebElement yourNameElement => Driver.FindElement(By.Id("et_pb_contact_name_2"));
        private IWebElement yourEmailElement => Driver.FindElement(By.Id("et_pb_contact_email_2"));
        private IWebElement yourPhoneNumberElement => Driver.FindElement(By.Id("et_pb_contact_phone_2"));
        private IWebElement yourCompanyNameElement => Driver.FindElement(By.Id("et_pb_contact_company_2"));
        private IWebElement yourMessageElement => Driver.FindElement(By.Id("et_pb_contact_message_2"));
        private IWebElement sendInformationButtonElement => Driver.FindElement(By.Name("et_builder_submit_button"));

        [SetUp]
        public void BeforeTest()
        {
            Driver.Url = "https://automanas.autobilis.lt/paslaugos-verslui";
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]

        public void FillForm()
        {
            yourNameElement.SendKeys("testuotojas");
            Thread.Sleep(5000);
            yourEmailElement.SendKeys("gerai@testuoju.lt");
            Thread.Sleep(5000);
            yourPhoneNumberElement.SendKeys("+90000");
            Thread.Sleep(5000);
            yourCompanyNameElement.SendKeys("vania corporated");
            Thread.Sleep(5000);
            yourMessageElement.SendKeys("soriukas testuoju jusu puslapi :D");
            Thread.Sleep(5000);
            sendInformationButtonElement.Click();
            Thread.Sleep(5000);

           // Assert.AreEqual("", yourNameElement.Text);
            Assert.AreEqual("", yourEmailElement.Text);
            Assert.AreEqual("", yourPhoneNumberElement.Text);
            Assert.AreEqual("", yourCompanyNameElement.Text);
            Assert.AreEqual("", yourMessageElement.Text);
            //Assert.AreEqual()  
        }

        [Test]
        public void EmptyFillForm()
        {
            sendInformationButtonElement.Click();
            Thread.Sleep(10000);
            
        }


    }
}
