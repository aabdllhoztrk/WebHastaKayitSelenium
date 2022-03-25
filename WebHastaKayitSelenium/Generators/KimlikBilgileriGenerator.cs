using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHastaKayitSelenium.Generators
{
    public class KimlikBilgileriGenerator
    {
        public string RandomName()
        {
            var personGenerator = new PersonNameGenerator();
            var firstName = personGenerator.GenerateRandomFirstName();
            return firstName;
        }

        public string RandomSurname()
        {
            var personGenerator = new PersonNameGenerator();
            string lastName = personGenerator.GenerateRandomLastName();
            return lastName;
        }
        public string RandomFatherName()
        {
            var personGenerator = new PersonNameGenerator();
            string fatherName = personGenerator.GenerateRandomMaleFirstName();
            return fatherName;
        }

        public string RandomMotherName() 
        {
            var personGenerator = new PersonNameGenerator();
            string motherName = personGenerator.GenerateRandomFemaleFirstName();
            return motherName;
        }

    }
}
