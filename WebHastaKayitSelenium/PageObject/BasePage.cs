using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebHastaKayitSelenium.PageObject
{
    public abstract class BasePage
    {
        private IWebDriver _driver;    
        protected IWebDriver Driver => _driver;


        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        protected object ExecuteJS(string script)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            var result=  js.ExecuteScript(script);
            return result;
        }

        protected void ExtShowMenu(string elementId)
        {
            var cmd = $"Ext.getCmp('{elementId}').showMenu()";
            ExecuteJS(cmd);
        }


        public IWebElement WaitForElement(By by)
        {
            
            const int WAIT_ELEMENT_TIMEOUT = 10;
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(Driver);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Timeout = TimeSpan.FromSeconds(WAIT_ELEMENT_TIMEOUT);
            wait.PollingInterval = TimeSpan.FromMilliseconds(5000); 
            wait.Message = "Element not found";
            var result =wait.Until( x => x.FindElement(by));
            return result;       
        }


        public IWebElement FindElementByXPath(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(element)));
        }

        public IWebElement FindElementById(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(element)));
        }
        public IWebElement FindElementByName(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(element)));
        }

        public IWebElement FindElementCssSelector(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
        }


        /*
                public IWebElement FindElementByName(string name)
                {
                    return WaitForElement(By.Name(name));
                }
                public IWebElement FindElementById(string id)
                {
                    return WaitForElement(By.Id(id));
                }   

                public IWebElement FindElementCssSelector(string cssSelector)
                {
                    return WaitForElement(By.CssSelector(cssSelector));
                }

                public IWebElement FindElementByXPath(string path)
                {
                    return WaitForElement(By.XPath(path));
                }

                public IWebElement FindElementByLinkText(string linkText)
                {
                    return WaitForElement(By.LinkText(linkText));
                }
        */



        public void CheckPageTitle(string expectedTitle)

        {
            string actualTitle = Driver.Title;
           
            Assert.AreEqual(actualTitle, expectedTitle);

            if (actualTitle ==expectedTitle)
            {
                Console.WriteLine(actualTitle + " is matching with expected value");
            }

            else
            {
                Console.WriteLine("Title is NOT matching with expected value");
            }

        }

       public void CheckLabelExisting(IWebElement actualLabel, string expectedLabel) 
        {
            string expected = expectedLabel;

            try
            {
                Assert.IsTrue(actualLabel.Text.Contains(expected));
                
            }
            catch (Exception e)
            {

                Console.WriteLine("Beklenen label sayfa kaynagında bulunamadi !!!" + "  Label: " + expected);
              
            }

        }

        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }

        public void switchtoFrame(string frameName)

        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.FrameToBeAvailableAndSwitchToIt(frameName));
        }

        public void goToUrl(string url)
        {
            Driver.Url = url;
        }

       

    }
}
