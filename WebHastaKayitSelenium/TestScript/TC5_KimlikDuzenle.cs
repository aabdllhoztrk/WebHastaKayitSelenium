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
    public class TC5_KimlikDüzenle : BaseTest
    {
        [Test]
        public void KimlikDUzenle() 
        {
            var loginPage = new LoginPage(driver);
            var hastaKayitHomePage = loginPage.LoginOlma();
            hastaKayitHomePage.KimlikDüzenleme();
            Console.WriteLine("TC5_KimlikDüzenle Basarili!!!");
        }

        [TearDown]
        public void Cikis() 
        {
            driver.Quit();
        }
    }
}
