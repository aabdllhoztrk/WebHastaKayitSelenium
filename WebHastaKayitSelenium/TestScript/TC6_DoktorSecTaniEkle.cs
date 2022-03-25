using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHastaKayitSelenium.BaseClass;
using WebHastaKayitSelenium.PageObject;

namespace WebHastaKayitSelenium.TestScript
{
     public class TC6_DoktorSecTaniEkle : BaseTest
    {

        [Test]
        public void AcildenDoktorSecmeveTaniEkleme() 
        {

            var loginPage = new LoginPage(driver);
            var hastaKayitHomePage = loginPage.LoginOlma();
            var acilPage = hastaKayitHomePage.YeniHastaKaydet();
            acilPage.DoktorVeTaniSec();
            Console.WriteLine("TC6_DoktorSecTaniEkle Basarili!!!");
          
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
