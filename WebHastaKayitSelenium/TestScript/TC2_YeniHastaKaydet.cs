using NUnit.Framework;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHastaKayitSelenium.BaseClass;
using WebHastaKayitSelenium.PageObject;

namespace WebHastaKayitSelenium.TestScript
{
    public class TC2_YeniHastaKaydet : BaseTest
    {
        [Test]
        public void YeniHastaOlusturAcileGonder()
        {
            
            var loginPage = new LoginPage(driver);
            var hastaKayitHomePage = loginPage.LoginOlma();
            hastaKayitHomePage.YeniHastaKaydet();
            Console.WriteLine("TC2_YeniHastaKaydet Basarili!!!");
                       
        }       

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
