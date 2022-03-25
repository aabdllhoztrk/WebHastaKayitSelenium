using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebHastaKayitSelenium.PageObject
{
    public class KayitAraPage : BasePage
    {

        public KayitAraPage(IWebDriver driver) : base(driver)
        {
        }

       
        public IWebElement txtHastaAdi => FindElementByName("txtHastaAdi");
        public IWebElement btnTamam => FindElementById("btnTamam");
        public IWebElement selectMehmetTurgut => FindElementByXPath("/html/body/form/div[1]/div[1]/div/div[3]/div/table/tbody/tr[1]"); //mehmet turgut hastası aranmaktadır.

        

        public void KayitArama()
        {
          //  Thread.Sleep(3000);
            txtHastaAdi.SendKeys("MEHMET");
            btnTamam.Click();
            switchtoFrame("Pencere_IFrame");
            Actions action = new Actions(Driver); //double click 
            action.DoubleClick(selectMehmetTurgut).Perform();  //double click
            Thread.Sleep(6000);
            Console.WriteLine("Kayit Arama Basarili");
        }
    }
}
