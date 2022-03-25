using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebHastaKayitSelenium.BaseClass;
using WebHastaKayitSelenium.PageObject;

namespace WebHastaKayitSelenium.TestScript
{
    public class TC3_KayitArama : BaseTest

    {
        [Test]
        public void KayitArama()
        {
            var loginPage = new LoginPage(driver);
            var hastaKayitHomePage = loginPage.LoginOlma();
            var kayitara = hastaKayitHomePage.KayitArama();         
            Thread.Sleep(3000);
            kayitara.KayitArama();
            Console.WriteLine("TC3_KayitArama Basarili!!!");    
        }

        [TearDown]
        public void Close() 
        {
            driver.Quit();
        }
    }
}
