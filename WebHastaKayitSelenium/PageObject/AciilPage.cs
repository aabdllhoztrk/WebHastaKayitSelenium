using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebHastaKayitSelenium.PageObject
{
   public class AciilPage : BasePage
    {
        public AciilPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement AcilMenuDown => FindElementByXPath("/html/body/form/div[1]/div/div[1]/div/div[1]/div/table/tbody[1]/tr/td/table/tbody/tr/td[2]/table/tbody/tr/td[2]/div");//Acil Sol Menüler
        public IWebElement Acil => FindElementByXPath("/html/body/div[4]/div/ul/li[1]"); //Acil Sol Menüler
        public IWebElement AcilPolikilinigiDown => FindElementByXPath("/html/body/form/div[1]/div/div[1]/div/div[1]/div/table/tbody[2]/tr/td/table/tbody/tr/td[2]/table/tbody/tr/td[2]/div"); //Acil Sol Menüler
        public IWebElement AcilPolikilinigi => FindElementByXPath("//li[contains(text(),'Acil Polikliniği')]");//Acil Sol Menüler
        public IWebElement btnDefaultTamam => FindElementByXPath("/html/body/div[6]/div[3]/div/div/a[1]");
        public IWebElement globalHastaAdi => FindElementByXPath("//div[contains(text(),'" + globalPatient + "')]");  //Hasta kayıttan gelen hasta
        public IWebElement selectDoktor => FindElementByXPath("//div[contains(text(),'BAHRİ URAK')]");
        public IWebElement BtnTumListe => FindElementById("BtnTumListe");
        public IWebElement TxtTaniArama => FindElementByName("TxtArama"); //Tani Listesi Formu
        public IWebElement selectTaniSec => FindElementByXPath("//div[contains(text(),'AKUT')]"); //Tani Listesi Formu
        public IWebElement btnTamam => FindElementByXPath("/html/body/form/div[6]/div[1]/div/div/a[1]"); //Tani Listesi Formu

        /// <summary>
        /// Radyoloji ve Labaratuar ile ilgili elementler.
        /// </summary>
        public IWebElement btnLab => FindElementById("BtnLab");
        public IWebElement txtArama => FindElementByName("TxtArama");
        public IWebElement selectAnanas => FindElementByXPath("//div[contains(text(),'Ananas')]");
        public IWebElement btnTmm => FindElementByXPath("/html/body/form/div[3]/div[2]/span/div/div[2]/div/div/a[1]");
        public IWebElement BtnRont => FindElementById("BtnRont");
        public IWebElement selectAortik => FindElementByXPath("//div[contains(text(),'Aortik')]");

        public IWebElement tabDosyaIslemleri => FindElementByXPath("/html/body/form/div[3]/div/span/div/div/div[1]/div[1]/div[2]/div/a[2]");
        public IWebElement BtnHastaYatir => FindElementById("BtnHastaYatir");
        public IWebElement selectGenelCerrahi => FindElementByXPath("//div[contains(text(),'Genel Cerrahi Servisi')]");
        public IWebElement iframe => FindElementByXPath(".//iframe[contains(@src,'/KarMed/Poliklinik/Frame/FrmListe')]");

        

        //iframe[contains(@src,'/KarMed/Poliklinik/Frame/FrmListe')]
       // iframe[src *= '/KarMed/Poliklinik/Frame/FrmListe']

        public static string globalPatient = PatientGenerator.Hasta.Adi;
        public void DoktorVeTaniSec() 
        {
            var currentWindow = Driver.CurrentWindowHandle;
            goToUrl("http://192.168.1.9/Karmed/Poliklinik/Default.aspx?Acil=T");   
            AcilMenuDown.Click();
            Acil.Click();
            AcilPolikilinigiDown.Click();
            AcilPolikilinigi.Click();
            btnDefaultTamam.Click();
            Actions doubleClickGlobalPatientName = new Actions(Driver); //double click 
            doubleClickGlobalPatientName.DoubleClick(globalHastaAdi).Perform();
            Driver.SwitchTo().Window(currentWindow);
            switchtoFrame("BaseWindow_IFrame");
            Thread.Sleep(2000);
            Actions doubleClickDoktor = new Actions(Driver); //double click 
            doubleClickDoktor.DoubleClick(selectDoktor).Perform();
            Driver.SwitchTo().Window(currentWindow);
            switchtoFrame("BaseWindow_IFrame");
            Thread.Sleep(2000);
            BtnTumListe.Click();
            Driver.SwitchTo().Window(currentWindow);
            switchtoFrame("baseWin_IFrame");
            TxtTaniArama.SendKeys("r52");
            selectTaniSec.Click();
            btnTamam.Click();
            btnDefaultTamam.Click();
            Thread.Sleep(9000);

           /*
            tabDosyaIslemleri.Click();
            BtnHastaYatir.Click();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(currentWindow);
            switchtoFrame("");
            selectGenelCerrahi.Click(); */           
        }


        public void HastaLabaratuaraGonder() 
        {
            var currentWindow = Driver.CurrentWindowHandle;
           // Thread.Sleep(3000);
            DoktorVeTaniSec();
            // btnDefaultTamam.Click();
            switchtoFrame("PnlHizmetListesi_IFrame");
            btnLab.Click();
            Driver.SwitchTo().Window(currentWindow);
            switchtoFrame("baseWin_IFrame");
            txtArama.SendKeys("as");
            selectAnanas.Click();
            btnTmm.Click();
            Driver.SwitchTo().Window(currentWindow);
            switchtoFrame("PnlHizmetListesi_IFrame");
            Thread.Sleep(5000);
            BtnRont.Click();
            Driver.SwitchTo().Window(currentWindow);
            switchtoFrame("baseWin_IFrame");
            txtArama.SendKeys("as");
            selectAortik.Click();
            btnTmm.Click();
        }       
    }
}

/*
WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ele(By.Id("BtnRont")));
SearchResult.Click()*/