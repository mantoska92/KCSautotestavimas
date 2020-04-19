using baigiamasis.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace baigiamasis.Tests
{
    public class AdUploadTest : BaseTest
    {

        private AddUploadPage uploadPage;
        [SetUp]
        public void InitPages()
        {

            loginPage = new LoginPage(Driver);
            homePage = new HomePage(Driver);
            uploadPage = new AddUploadPage(Driver);
        }

        [Test]

        public void AdvertUploadTest()
      
        {
            loginPage.ClickLoginbuttonElement();
            Thread.Sleep(1000);

            loginPage.EnterUserEmail("testeris@testas.lt");
            Thread.Sleep(1000);

            loginPage.EnterPassword("slaptazodis");
            Thread.Sleep(1000);


            loginPage.ClickSubmitLoginButton();
            Thread.Sleep(1000);
            uploadPage.ClickAddAdvertButton();
            Thread.Sleep(2000);
            uploadPage.ClickChoseVehicleType();
            Thread.Sleep(1000);
            uploadPage.ClickMotorcycleElemet();
            Thread.Sleep(1000);


            uploadPage.ClickMotorcycleMakeElement();
            Thread.Sleep(1000);
            uploadPage.ClickMotorcycleMakeSelected();
            Thread.Sleep(1000);
            uploadPage.ClickMotorcycleModelElement();
            Thread.Sleep(1000);
            uploadPage.ClickMotorcycleModelSelected();
            Thread.Sleep(1000);
            uploadPage.ClickMotorcycleMakeYear();
            Thread.Sleep(1000);
            uploadPage.ClickMotorcycleMakeMonth();
            Thread.Sleep(1000);
            uploadPage.ChoseMotorcyclePower();
            Thread.Sleep(1000);
            uploadPage.ClickCubicCapacityElement();
            Thread.Sleep(1000);
            uploadPage.ClickCubicCapacitySelected();
            Thread.Sleep(1000);
            uploadPage.ClickMotorcyclePrice();
            Thread.Sleep(1000);
            uploadPage.ClickPriceSelected();
            Thread.Sleep(1000);
            uploadPage.ClickAgreeTermsCheckBox();
            Thread.Sleep(1000);
            //uploadPage.ClickGetNotificationsCheckBox();
            Thread.Sleep(1000);
            uploadPage.SubmitAdvert();
            Thread.Sleep(1000);
            uploadPage.SubmitDesktopAdvert();
            Thread.Sleep(6000);

            //uploadPage.AssertAdvert();
        }

    }

}
