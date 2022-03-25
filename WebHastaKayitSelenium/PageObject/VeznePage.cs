using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebHastaKayitSelenium.PageObject
{
   public class VeznePage : BasePage
    {
        public VeznePage(IWebDriver driver) : base(driver)
        {
        }

        public static string globalPatient = PatientGenerator.Hasta.Adi;

        public IWebElement btnDropDown => FindElementByXPath("/html/body/form/div[10]/div[2]/span/div/table/tbody/tr/td[2]/table/tbody/tr/td[2]");
        public IWebElement selectAnaVezne => FindElementByXPath("//li[contains(text(),'Ana Vezne')]");
        public IWebElement btnVezneSecimTamam => FindElementById("btnTamam-btnInnerEl");
        public IWebElement globalHastaAdi => FindElementByXPath("//div[contains(text(),'" + globalPatient + "')]");
        public IWebElement btnUyariTamam => FindElementById("/html/body/div[4]/div[3]/div/div/a[1]");
        public IWebElement btnNakitTahsilati => FindElementById("BtnNakitTahsilati");
        public IWebElement btnMakbuz => FindElementById("BtnMakbuzTahsilat");
        public IWebElement btnTahsilEt => FindElementById("BtnTahsilEt");

        public AciilPage Odemeİslemleri() 
        {                     
            goToUrl("http://192.168.1.9/Vezne/Default.aspx");          
            LoginPage login = new LoginPage(Driver);
            login.LoginOlma();
            btnDropDown.Click();
            selectAnaVezne.Click();
            btnVezneSecimTamam.Click();
            switchtoFrame("CPanel_IFrame");
            Thread.Sleep(2000);
            globalHastaAdi.Click();
            //btnUyariTamam.Click();
            Driver.SwitchTo().DefaultContent();
            btnNakitTahsilati.Click();
            switchtoFrame("Pencere_IFrame");
            btnMakbuz.Click();
            Thread.Sleep(2000);
            btnTahsilEt.Click();
            Thread.Sleep(6000);
            return new AciilPage(Driver);
        }
    }
}
