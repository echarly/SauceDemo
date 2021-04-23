using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo
{
    public class BasePage
    {

        static public IWebDriver driver;

        // Titles
        public string ProductsTitleText = "PRODUCTS";
        public string ErrorMessageText = "Epic sadface: Username and password do not match any user in this service";

        //URL
        string url = "https://www.saucedemo.com/";

        #region Methods
        public BasePage InitializeDriver()
        {
            driver = new ChromeDriver("C:\\Chromedriver\\");

            return this;
        }

        public BasePage OpenBrowser()
        {
            driver.Url = url;
            Console.WriteLine("URL: " + url);

            return this;
        }

        public BasePage EnterText(By element, string text)
        {

            driver.FindElement(element).SendKeys(text);
            Console.WriteLine("Text sent: " + text);

            return this;
        }

        public BasePage Click(By element)
        {

            driver.FindElement(element).Click();

            return this;
        }

        public BasePage WaitTime(By element)
        {
            //-----Impicit
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Explicit
            /*
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(drv => drv.FindElement(element));
            */

            return this;
        }

        public string ObtainText(By element)
        {
            string text = driver.FindElement(element).Text;

            Console.WriteLine("Text obtained: " + text);

            return text;
        }

        public BasePage SelectDropDown(By element, string option)
        {
            driver.FindElement(element).SendKeys(option);
            Console.WriteLine("Option selected: " + option);

            return this;
        }

        public bool ElementDisplayed(By element)
        {
            bool display = driver.FindElement(element).Displayed;
            Console.WriteLine("Element Displayed: " + display);

            return display;
        }

        public BasePage NavigateToElement(By element)
        {
            /*
            var el = driver.FindElement(element);
            Actions actions = new Actions(driver);
            actions.MoveToElement(el);
            */

/*          IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
            */

            //to perform Scroll on application using Selenium
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,-550)", "");

            return this;
        }

        public void CloseDriver()
        {
            driver.Quit();
        }
        #endregion
    }
}