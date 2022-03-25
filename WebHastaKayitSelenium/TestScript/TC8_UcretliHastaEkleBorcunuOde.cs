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
    class TC8_UcretliHastaEkleBorcunuOde: BaseTest
    {
        [Test]
        public void UcretliHastaEklemeveBorcunuOdeme() 
        {
            var loginpage = new LoginPage(driver);
            var hastaKayitHomePage = loginpage.LoginOlma();
            var veznepage = hastaKayitHomePage.UcretliHastaKaydet();
            veznepage.Odemeİslemleri();
            var acilPage = new AciilPage(driver);
            acilPage.DoktorVeTaniSec();

            Console.WriteLine("TC8_UcretliHastaEkleBorcunuOde basarili !!!");
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
