using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebHastaKayitSelenium.Generators;

namespace WebHastaKayitSelenium.PageObject
{
    public class HastaKayitHomePage : BasePage
    {
        public HastaKayitHomePage(IWebDriver driver) : base(driver)
        {
            
        }

        class HastaBilgisi
        {
            private string _adi;
            public string Adi {
                get => _adi.ToUpper();
                set => _adi = value; 
            }
                      
        }

        private static HastaBilgisi _hasta;
        private static HastaBilgisi Hasta
        {
            get => _hasta ?? (_hasta = new HastaBilgisi
            {
                Adi = kimlikBilgileriGenerator.RandomName()                
            });
            set => _hasta = value;
        }


       

        private static KimlikBilgileriGenerator kimlikBilgileriGenerator = new KimlikBilgileriGenerator();
        public IWebElement btnKayitArama => FindElementById("BtnKayitAra");// üst Menü
        public IWebElement btnDuzenle => FindElementByXPath("/html/body/form/div[1]/div[1]/div/div/a[2]");    // üst Menü  
        public IWebElement btnIslemler => FindElementById("btnParam"); //Üst Menü
        public IWebElement txtTcKimlikNo => FindElementById("txtTc-inputEl");
        public IWebElement btnMessageKimlikGuncelleme => FindElementById("button-1007");
        
        public IWebElement btnDefaultButton => FindElementCssSelector("div[id*=message]>a.x-btn-default-small[id*=button]:not([style*=\"display: none\"])");
        public IWebElement txtAd => FindElementById("txtAd-inputEl");//KimlikBilgileri
        public IWebElement txtSoyad => FindElementById("txtSoyad-inputEl");//KimlikBilgileri
        public IWebElement txtBaba => FindElementById("txtBaba-inputEl");//KimlikBilgileri
        public IWebElement txtAnne => FindElementById("txtAnne-inputEl");//KimlikBilgileri
        public IWebElement cmbCinsiyet => FindElementById("cmbCinsiyet-inputEl");
        public IWebElement uyruk => FindElementById("cmbUyruk-inputEl");//KimlikBilgileri

        public IWebElement selectTurkiyeCumhuriyeti => FindElementByXPath("//li[contains(text(),'TÜRKİYE')]");//KimlikBilgileri


        public IWebElement BtnDogumYeriSec => FindElementById("BtnDogumYeriSec");//KimlikBilgileri
        public IWebElement txtDogumTarih => FindElementByName("DogumTarihi");//KimlikBilgileri
        public IWebElement txtogrenimDurumu => FindElementById("cmbOgrenimDurum-inputEl");//KimlikBilgileri
        public IWebElement selectMerkez => FindElementByXPath("/html/body/form/div[1]/div[3]/div/table/tbody/tr[1]/td[1]"); //KimlikBilgileri
        
        public IWebElement BtnSosyalGuvenceSec => FindElementById("BtnSosyalGuvenceSec"); //KimlikBilgileri
        public IWebElement btnAdressGuncelleUyari => FindElementByXPath("/html/body/div[3]/div[3]/div/div/a[1]"); //KimlikBilgileri
        public IWebElement tabKimlikBilgileri => FindElementByXPath("/html/body/form/div[2]/div/div[1]/div/div/div/div/div[1]/div[1]/div[2]/div/a[1]");                 
        public IWebElement sosyalGuvenceUcretliHasta => FindElementByXPath("//div[contains(text(),'Ücretli')]");
        public IWebElement sosyalGuvenceUcretliHasta1 => FindElementByXPath("/html/body/form/div[2]/div[3]/div/table/tbody/tr[1]/td/div");
        public IWebElement SosyalGuvence_Sgk => FindElementByXPath("//div[contains(text(),'S.G.K')]"); //KimlikBilgileri
        public IWebElement SosyalGuvence_Ssk => FindElementByXPath("/html/body/form/div[2]/div[3]/div/table/tbody/tr[13]/td/div");//KimlikBilgileri
        public IWebElement btnKimlikGuncelle => FindElementById("btnKimlikGuncelle");//KimlikBilgileri
        public IWebElement BtnKpsSorgula => FindElementById("BtnGssKimlikSorgulama"); //KimlikBilgileri
        public IWebElement selectAcil => FindElementById("ext-gen1676");//polikiliniksekmesi      
        public IWebElement selectAcilPolikinligi => FindElementByXPath("/html/body/form/div[4]/div[3]/div/table/tbody/tr[2]/td[1]");//polikiliniksekmesi
        public IWebElement btnOnKayitEvet => FindElementById("button-1006");  //polikiliniksekmesi
        public IWebElement btnCikis => FindElementByXPath("/html/body/form/div[1]/div[1]/div/div/a[8]");//KimlikBilgileri
        public IWebElement txtDeger => FindElementByName("txtArananIfade");

    /// <summary>
    /// Dosya Açma Elementleri
    /// </summary>
        public IWebElement btnKptAftifHastaBorcListesiForm => FindElementById("BtnKapat");       
        public IWebElement AcilfromServisAdi => FindElementById("gridview-1054-record-1");
        public IWebElement AcilpoliklinigiServisAdi => FindElementByXPath("//div[contains(text(),'Acil Pol')]");
        public IWebElement OnKayitOnaylaEvet => FindElementById("button-1006");
        public IWebElement turCombo => FindElementByXPath("/html/body/form/div[1]/div[1]/div/div/div[1]/div/span/div/table[1]/tbody/tr/td[2]/div/div/div/table[2]/tbody/tr/td[2]/table/tbody/tr/td[2]/div");
        public IWebElement selectTcKimlik => FindElementByXPath("/html/body/div[2]/div/ul/li[2]");
       

        public IWebElement tabPoliklinik => FindElementByXPath("/html/body/form/div[2]/div/div[3]/div[1]/div[1]/div[2]/div/a[1]"); //PoliklininkSekmesi
        public IWebElement altTab_HastaGecmisDosyalari => FindElementByXPath("/html/body/form/div[1]/div[1]/div[1]/div[2]/div/a[1]");//PolikliniklkAltSekmeeleri
        public IWebElement altTab_HastaRandevulari => FindElementByXPath("/html/body/form/div[1]/div[1]/div[1]/div[2]/div/a[2]"); //PolikliniklkAltSekmeeleri
        public IWebElement alttab_Triaj => FindElementByXPath("/html/body/form/div[1]/div[1]/div[1]/div[2]/div/a[3]"); //PolikliniklkAltSekmeeleri
        public IWebElement tabAnlasmaliKurum => FindElementByXPath("/html/body/form/div[2]/div/div[3]/div[1]/div[1]/div[2]/div/a[2]");// AnlaşmalıKurumSekmesi
        public IWebElement selectKozanDevlet => FindElementByXPath("/html/body/form/div[1]/div[3]/div/table/tbody/tr[2]/td/div");//AnlaşmalıKurumSekmesiAltSekmeleri
        public IWebElement altTab_HizmetListesi => FindElementByXPath("/html/body/form/div[3]/div[1]/div[1]/div[2]/div/a[1]");//AnlaşmalıKurumSekmesiAltSekmeleri
        public IWebElement alt_Tab_TeletipSorgulananHizmetler => FindElementByXPath("/html/body/form/div[3]/div[1]/div[1]/div[2]/div/a[2]");//AnlaşmalıKurumSekmesiAltSekmeleri
        public IWebElement tabSonucSirasi => FindElementByXPath("/html/body/form/div[2]/div/div[3]/div[1]/div[1]/div[2]/div/a[3]");//SonuçSırasıSekmesi
        public IWebElement selectfromSonucSirasiList => FindElementByXPath("/html/body/form/div[1]/div[3]/div/table/tbody/tr[4]");//SonuçSırasıSekmesi
        public IWebElement tabEnjPansuman => FindElementByXPath("/html/body/form/div[2]/div/div[3]/div[1]/div[1]/div[2]/div/a[4]");//Enj Pansuman Sekmesi
        public IWebElement selectYaraPansuman => FindElementByXPath("/html/body/form/div[1]/div/div/div/div[1]/div[3]/div/table/tbody/tr[4]/td[1]");//Enj Pansuman Sekmesi
        public IWebElement tabKampanyaCheckUp => FindElementByXPath("/html/body/form/div[2]/div/div[3]/div[1]/div[1]/div[2]/div/a[5]");//KmpanyaCheckupSekmesi
        public IWebElement tabOnKayit => FindElementByXPath("/html/body/form/div[2]/div/div[3]/div[1]/div[1]/div[2]/div/a[8]");//ÖnkayıtSekmesi
        public IWebElement radioTumListeFromOnKayit => FindElementByXPath("/html/body/form/div[1]/div[1]/div/div/table/tbody/tr/td[2]/div/div/div/table[2]/tbody/tr/td[2]/div/div/div/table[1]/tbody/tr/td[2]/input[1]");//ÖnkayıtSekmesi
        public IWebElement tabRandevu => FindElementByXPath("/html/body/form/div[2]/div/div[3]/div[1]/div[1]/div[2]/div/a[9]"); //RandevuSekmesi
        public IWebElement checkOnayVerilmeyenler => FindElementById("chkOnaysizlar-inputEl"); //RandevuSekmesi

        public IWebElement btnKapatfromHastaninTümKayitli => FindElementByXPath("/html/body/form/div[1]/div[1]/div/div/a[2]");//KmpanyaCheckupSekmesi
        public IWebElement selectAciklamaFromKampanya => FindElementByXPath("/html/body/form/div[4]/div[3]/div/table/tbody/tr[2]");//KmpanyaCheckupSekmesi


        public IWebElement btnyeniDoganDosyasiniDuzenlefromİslemler => FindElementById("MenuItem1"); //İslemler Menüsü
        public IWebElement btnhataliİslemTamam => FindElementByXPath("/html/body/div[3]/div[3]/div/div/a[1]"); //İslemler Menüsü
        public IWebElement btnVazgec => FindElementById("btnVazgec"); //İslemler Menüsü
        public IWebElement btnTamamfromAktifHasta => FindElementByXPath("/html/body/div[5]/div[1]/div/div/div/div[2]"); //İslemler Menüsü
        public IWebElement lbltumListe => FindElementById("RadioTum-boxLabelEl");

        /// <summary>
        /// Adress Bilgileri Tabı altındaki elementleri içermektedir.
        /// </summary>
        public IWebElement tabAdresBilgileri => FindElementByXPath("//span[contains(text(),'Adres Bilgileri')]");
        public IWebElement BtnAdresKodSec => FindElementById("BtnAdresKodSec");           
        public IWebElement selectSakarya => FindElementByXPath("//div[contains(text(),'SAKARYA')]");
        public IWebElement selectAdapazari => FindElementByXPath("//div[contains(text(),'ADAPAZAR')]");
        public IWebElement selectAdaPazariMerkez => FindElementByXPath("//div[contains(text(),'MERKEZ')]");
        public IWebElement selectAdaPazariMerkez1 => FindElementByXPath("/html/body/form/div[1]/div[3]/div/table/tbody/tr[4]/td[1]/div/img[4]");
        public IWebElement selectBudaklar => FindElementByXPath("//div[contains(text(),'BUDAKLAR')]");
        public IWebElement txtAcikadres => FindElementById("txtAcikadres-inputEl");
        public IWebElement btnIlIlceSec => FindElementByXPath("/html/body/form/div[2]/div/div[1]/div/div/div/div/div[2]/div[2]/div[1]/div[1]/table/tbody[6]/tr/td/table/tbody/tr/td[2]/div/div/div/table[2]/tbody/tr/td[2]/a[1]");
        public IWebElement selectCeyhan => FindElementByXPath("//div[contains(text(),'CEYHAN')]");
        public IWebElement txtEvTelefon => FindElementById("txtEvTelefon-inputEl");   
        public IWebElement btnAdresTipiDropDown => FindElementByXPath("/html/body/form/div[2]/div/div[1]/div/div/div/div/div[2]/div[2]/div[1]/div[1]/table/tbody[2]/tr/td/table/tbody/tr/td[2]/table/tbody/tr/td[2]");
        public IWebElement selectIkamet => FindElementByXPath("//li[contains(text(),'SÜREK')]");
        public IWebElement btnIkametTuruDropDown => FindElementByXPath("/html/body/form/div[2]/div/div[1]/div/div/div/div/div[2]/div[2]/div[1]/div[1]/table/tbody[3]/tr/td/table/tbody/tr/td[2]/table/tbody/tr/td[2]");
        public IWebElement selectBelde => FindElementByXPath("//li[contains(text(),'Belde')]");
        public IWebElement chckBoxEposta => FindElementById("EPostaYok_-inputEl");
        public IWebElement btnAdresGuncelle => FindElementById("btnAdresGuncelle");
        

        public static string globalPatient = PatientGenerator.Hasta.Adi;

        public void Cikis()
        {

            //ExtShowMenu("btnParam");
            //btnyeniDoganDosyasiniDuzenlefromİslemler.Click();
            //Driver.SwitchTo().Frame("Pencere_IFrame");
            //Thread.Sleep(2000);
            //btnhataliİslemTamam.Click();
            //btnVazgec.Click();
            //Thread.Sleep(4000);      
            //btnTamamfromAktifHasta.Click();            
            Thread.Sleep(3000);
            CheckPageTitle("Hasta Kayıt - Kardelen Yazılım");          
            btnCikis.Click();
            Thread.Sleep(3000);                      
            Console.WriteLine("Cikis Yapildi.");
        }

        public void ButunButonlaraTikla()

        {
            
            var currentWindow = Driver.CurrentWindowHandle;
            txtDeger.SendKeys("1726");
            Actions action = new Actions(Driver); //clink enter
            action.SendKeys(txtDeger, Keys.Enter).Perform();  //clink enter
          //  switchtoFrame("window-1175_IFrame");
          //  btnKptAftifHastaBorcListesiForm.Click();
          //  btnAdressGuncelleUyari.Click();
            Thread.Sleep(10000);
            tabPoliklinik.Click();
            switchtoFrame("pnlPoliklinikListesi_IFrame");
            altTab_HastaGecmisDosyalari.Click();
            altTab_HastaRandevulari.Click();
            alttab_Triaj.Click();
            Driver.SwitchTo().Window(currentWindow);
            tabAnlasmaliKurum.Click();
            switchtoFrame("pnlAnlasmaliKurumListesi_IFrame");
            selectKozanDevlet.Click();
            altTab_HizmetListesi.Click();
            alt_Tab_TeletipSorgulananHizmetler.Click();
            Driver.SwitchTo().Window(currentWindow);
            tabSonucSirasi.Click();
            switchtoFrame("pnlLabDosyaListesi_IFrame");
          //  selectfromSonucSirasiList.Click();
            Driver.SwitchTo().Window(currentWindow);
            tabEnjPansuman.Click();
            switchtoFrame("pnlEnjPansuman_IFrame");
            selectYaraPansuman.Click();
            Driver.SwitchTo().Window(currentWindow);
            tabKampanyaCheckUp.Click();
            tabOnKayit.Click();
            switchtoFrame("pnlOnKayitListesi_IFrame");
            CheckLabelExisting(lbltumListe, "Tum Liste");
            radioTumListeFromOnKayit.Click();
            Driver.SwitchTo().Window(currentWindow);
            tabRandevu.Click();
            switchtoFrame("pnlRandevuListesi_IFrame");
            checkOnayVerilmeyenler.Click();
            Console.WriteLine("Butonlara Tiklandi");           
        }

        public AciilPage YeniHastaKaydet()
        {
            var topWindow = Driver.CurrentWindowHandle;

            KimlikBilgileriGir();
            Actions action = new Actions(Driver); //double click 
            action.DoubleClick(SosyalGuvence_Sgk).Perform();  //double click
            switchtoFrame("Pencere_IFrame");
            Actions action1 = new Actions(Driver); //double click            
            action1.DoubleClick(SosyalGuvence_Ssk).Perform();  //double click            
            Driver.SwitchTo().Window(topWindow);
            Thread.Sleep(1000);
            btnKimlikGuncelle.Click();
            AdresBilgleriDoldur();
            HastayiAcileGonder();

            return new AciilPage(Driver);
        }
         
        
        public VeznePage UcretliHastaKaydet() 
        {
            var topWindow = Driver.CurrentWindowHandle;
            KimlikBilgileriGir();
            Actions action = new Actions(Driver); //double click 
            action.DoubleClick(sosyalGuvenceUcretliHasta).Perform();  //double click
            switchtoFrame("Pencere_IFrame");
            Actions action1 = new Actions(Driver); //double click            
            action1.DoubleClick(sosyalGuvenceUcretliHasta1).Perform();  //double click            
            Driver.SwitchTo().Window(topWindow);
            btnKimlikGuncelle.Click();
            Thread.Sleep(3000);
            btnAdressGuncelleUyari.Click();
            AdresBilgleriDoldur();
            HastayiAcileGonder();
            return new VeznePage(Driver);
        }
             
        public void KimlikDüzenleme() 
        {
            var kimlikBilgileriGenerator = new KimlikBilgileriGenerator();           
            txtDeger.SendKeys("3602");
            Actions action = new Actions(Driver); //clink enter
            action.SendKeys(txtDeger, Keys.Enter).Perform();  //clink enter
            /*
            switchtoFrame("window-1175_IFrame");
            btnKptAftifHastaBorcListesiForm.Click();
            btnAdressGuncelleUyari.Click();
            Driver.SwitchTo().Frame("window-1174_IFrame");
            btnKptAftifHastaBorcListesiForm.Click();
            tabKimlikBilgileri.Click();
            */
            Thread.Sleep(3000);
            btnDuzenle.Click();
            Thread.Sleep(2000);
            txtAd.Clear();
            txtSoyad.Clear();
            txtBaba.Clear();
            txtAnne.Clear();
            txtAd.SendKeys(kimlikBilgileriGenerator.RandomName());
            txtSoyad.SendKeys(kimlikBilgileriGenerator.RandomSurname());
            txtBaba.SendKeys(kimlikBilgileriGenerator.RandomName());
            txtAnne.SendKeys(kimlikBilgileriGenerator.RandomMotherName());
            Actions clickF2 = new Actions(Driver); //clink enter
            clickF2.SendKeys(Keys.Enter).Perform();  //clink enter
          //  Thread.Sleep(2000);
            Console.WriteLine("Kimlik Düzenlendi!!!");
        }


        public KayitAraPage KayitArama()
        {
            var topWindow = Driver.CurrentWindowHandle;
            Driver.SwitchTo().Window(topWindow);
            Thread.Sleep(3000);
            btnKayitArama.Click();
            switchtoFrame("Pencere_IFrame");
            return new KayitAraPage(Driver);
            
        }

        public void KpsSorgula()
        {
            txtTcKimlikNo.SendKeys("16535732170");
            BtnKpsSorgula.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Kps Sorgulandı.");
        }

         /// <summary>
        /// Kimlik bilgilerini doldur
        /// </summary>
        public void KimlikBilgileriGir() 
        {            
            var topWindow = Driver.CurrentWindowHandle;
            txtTcKimlikNo.SendKeys("" + RandomTcNo());
            txtAd.SendKeys(globalPatient);
            Thread.Sleep(2000);
            btnDefaultButton.Click();
            txtSoyad.SendKeys(kimlikBilgileriGenerator.RandomSurname());
            txtBaba.SendKeys(kimlikBilgileriGenerator.RandomName());
            txtAnne.SendKeys(kimlikBilgileriGenerator.RandomMotherName());
            BtnDogumYeriSec.Click();
            switchtoFrame("frmGenelListe_IFrame");
            Actions action2 = new Actions(Driver); //double click 
            action2.DoubleClick(selectMerkez).Perform();  //double click
            Driver.SwitchTo().Window(topWindow);
            txtDogumTarih.SendKeys("1.02.1994");
            Driver.SwitchTo().Window(topWindow);
            cmbCinsiyet.SendKeys("KADIN");
            txtogrenimDurumu.SendKeys("LİSANS");
            uyruk.SendKeys("TÜRKİYE CUMHURİYETİ");
          //  selectTurkiyeCumhuriyeti.Click();
            BtnSosyalGuvenceSec.Click();
            switchtoFrame("frmGenelListe_IFrame");
        }

        /// <summary>
        /// Adress bilgilerini doldur
        /// </summary>
        public void AdresBilgleriDoldur() 
        {
            var topWindow = Driver.CurrentWindowHandle;
            tabAdresBilgileri.Click();
            btnDuzenle.Click();
            btnAdresTipiDropDown.Click();
            selectIkamet.Click();
            btnIkametTuruDropDown.Click();
            selectBelde.Click();
            BtnAdresKodSec.Click();
            switchtoFrame("Pencere_IFrame");
            Actions doubleClicktoSakarya = new Actions(Driver);
            doubleClicktoSakarya.DoubleClick(selectSakarya).Perform();
            Actions doubleClicktoAdaPazari = new Actions(Driver);
            doubleClicktoAdaPazari.DoubleClick(selectAdapazari).Perform();
            Actions doubleClicktoMerkez = new Actions(Driver);
            doubleClicktoMerkez.DoubleClick(selectAdaPazariMerkez).Perform();
            Actions doubleClicktoMerkez1 = new Actions(Driver);
            doubleClicktoMerkez1.DoubleClick(selectAdaPazariMerkez1).Perform();
            Actions doubleClicktoBudaklar = new Actions(Driver);
            doubleClicktoBudaklar.DoubleClick(selectBudaklar).Perform();
            Driver.SwitchTo().Window(topWindow);
            txtAcikadres.SendKeys("Bahceli Evler Mah. 1825 Sok.");
            Thread.Sleep(1000);
            btnIlIlceSec.Click();
            switchtoFrame("BaseWindow_IFrame");
            Actions doubleClicktoCeyhan = new Actions(Driver);
            doubleClicktoCeyhan.DoubleClick(selectCeyhan).Perform();
            Driver.SwitchTo().Window(topWindow);
            txtEvTelefon.Click();
            txtEvTelefon.SendKeys("5384489865");
            chckBoxEposta.Click();
            btnAdresGuncelle.Click();
            Thread.Sleep(4000);
        }

        /// <summary>
        /// Acile gonder
        /// </summary>
        public void HastayiAcileGonder() 
        {           
            switchtoFrame("pnlPoliklinikListesi_IFrame");
            AcilfromServisAdi.Click();
            Actions action3 = new Actions(Driver); //double click 
            action3.DoubleClick(AcilpoliklinigiServisAdi).Perform();  //double click
            OnKayitOnaylaEvet.Click();
            Thread.Sleep(5000);
            Console.WriteLine("Acil Polikliniğine Hasta Gönderildi");
            
        }

        //Random TC.No Üret
        public string RandomTcNo()
        {
            return TcNoGenerator.Generate();
        }   
    }
}