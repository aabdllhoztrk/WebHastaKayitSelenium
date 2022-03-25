using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHastaKayitSelenium.Generators;

namespace WebHastaKayitSelenium
{
   public class PatientGenerator
    {
       
        private static KimlikBilgileriGenerator kimlikBilgileriGenerator = new KimlikBilgileriGenerator();

        private string _adi;
        public string Adi
        {
            get => _adi.ToUpper();
            set => _adi = value;
        }

        private static PatientGenerator _hasta;
        public static PatientGenerator Hasta
        {
            get => _hasta ?? (_hasta = new PatientGenerator
            {
                Adi = kimlikBilgileriGenerator.RandomName()
            });
            set => _hasta = value;
        }

        

    }  

}
