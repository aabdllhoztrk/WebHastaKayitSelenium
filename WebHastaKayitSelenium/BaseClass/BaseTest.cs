using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHastaKayitSelenium.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]

        public void NavigatetoKarmed()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");          
            driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(4));
            driver.Manage().Window.Maximize();
            driver.Url = "http://192.168.1.9/karmed/hastakayit/Default.aspx";
        }
        
    }
} 
