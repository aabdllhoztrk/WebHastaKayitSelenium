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
    class TC0_ButonlaraTikla : BaseTest
    {
        [Test]
        public void ButonlaraTik()
        {
            var loginPage = new LoginPage(driver);
            var HastaKayitHomePage = loginPage.LoginOlmawithEdmx();
            HastaKayitHomePage.ButunButonlaraTikla();
            Console.WriteLine("TC1_Login Basarili!!!");

        }

        [TearDown]
        public void BrowserKapat() 
        {
            driver.Close();
        }
    }
}
