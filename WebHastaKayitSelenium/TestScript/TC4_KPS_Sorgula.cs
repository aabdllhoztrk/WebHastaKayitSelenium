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
    public class TC4_KPS_Sorgula : BaseTest
    {
        [Test]
        public void TcSorgula() 
        {
            var loginpage = new LoginPage(driver);
            var hastaKayitHomePage = loginpage.LoginOlma();
            hastaKayitHomePage.KpsSorgula();
            Console.WriteLine("TC4_KPS_Sorgula Basarili!!!");
        }

        [TearDown]
        public void Cikis() 
        {
            driver.Quit();
        }
    }
}
