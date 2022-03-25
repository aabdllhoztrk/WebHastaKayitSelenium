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
    class TC7_LabveRadGonder: BaseTest
    {

        [Test]
        public void LabRadGonderme()
        {
            var loginPage = new LoginPage(driver);
            var hastaKayitHomePage = loginPage.LoginOlma();
            var acilPage = hastaKayitHomePage.YeniHastaKaydet();
            acilPage.HastaLabaratuaraGonder();
            Console.WriteLine("TC7_LabveRadGonder Basarili!!!");

        }
        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
