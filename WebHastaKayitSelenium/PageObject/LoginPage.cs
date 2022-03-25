using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebHastaKayitSelenium.PageObject
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement txtUserName => FindElementByName("txtUsername");
        public IWebElement txtPassword => FindElementByName("txtPassword");
        public IWebElement btnLogin => FindElementById("BtnLogin");
        public IWebElement LblModulAdi => FindElementById("ModulSurum");

        
        public HastaKayitHomePage LoginOlma()
        {
            CheckLabelExisting(LblModulAdi,"Sürüm");
            txtUserName.SendKeys("AO");
            txtPassword.SendKeys("Ao12.");
            btnLogin.Click();         
            Thread.Sleep(2000);
            return new HastaKayitHomePage(Driver);
            
        }
        public HastaKayitHomePage LoginOlmawithEdmx()
        {
            CheckPageTitle("Kardelen Yazılım");
            Thread.Sleep(4000);
            txtUserName.SendKeys("AO");
            txtPassword.SendKeys("Ao12.");
            btnLogin.Click();
         //   Thread.Sleep(5 * 60 * 1000);
            return new HastaKayitHomePage(Driver);
        }
    }
}



