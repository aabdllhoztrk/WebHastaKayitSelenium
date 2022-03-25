using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHastaKayitSelenium.BaseClass;
using WebHastaKayitSelenium.PageObject;

namespace WebHastaKayitSelenium.TestScript
{
    class TC1_Login : BaseTest
    {
        

        [Test]
        public void Login()
        {          
                var loginPage = new LoginPage(driver);
                var hastaKayitHomePage = loginPage.LoginOlma();
                Assert.NotNull(hastaKayitHomePage);
                Assert.IsTrue(driver.Url.Contains("HastaKayit/default.aspx"));
                hastaKayitHomePage.Cikis();
                Console.WriteLine("Login Olma Basarili!!!");
        }

         
        [TearDown]
        public void CloseBrowser() 
        {                                
            driver.Quit();
        }     
    }
}
