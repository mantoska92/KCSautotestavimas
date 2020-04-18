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
            
            loginPage.EnterUserEmail("testeris@testas.lt");
            
            loginPage.EnterPassword("slaptazodis");
            
            loginPage.ClickSubmitLoginButton();
            Thread.Sleep(6000);
            uploadPage.ClickAddAdvertButton();
            Thread.Sleep(6000);
            uploadPage.ClickMotorcycleElemet();
            Thread.Sleep(5000);
            uploadPage.ClickChoseVehicleType();
            
            uploadPage.ClickMotorcycleMakeElement();
            
            uploadPage.ClickMotorcycleMakeSelected();
           
            uploadPage.ClickMotorcycleModelElement();
           
            uploadPage.ClickMotorcycleModelSelected();
            
            uploadPage.ClickMotorcycleMakeYear();
           
            uploadPage.ClickMotorcycleMakeMonth();
           
            uploadPage.ChoseMotorcyclePower();
            
            uploadPage.ClickCubicCapacityElement();
           
            uploadPage.ClickCubicCapacitySelected();
            
            uploadPage.ClickMotorcyclePrice();
           
            uploadPage.ClickPriceSelected();
           
            uploadPage.ClickAgreeTermsCheckBox();
           
            uploadPage.ClickGetNotificationsCheckBox();
          
            uploadPage.SubmitAdvert();
           
            uploadPage.SubmitDesktopAdvert();

        }

    }

}
