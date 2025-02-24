﻿using OpenQA.Selenium;
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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            return this;
        }

        public string ObtainText(By element)
        {
            string text = driver.FindElement(element).Text;

            Console.WriteLine("Text obtained: " + text);

            return text;
        }

        public bool ElementDisplayed(By element)
        {
            bool display = driver.FindElement(element).Displayed;
            Console.WriteLine("Element Displayed: " + display);

            return display;
        }

        public void CloseDriver()
        {
            driver.Quit();
        }

        public BasePage SelectDropDown(IWebElement element, string option)
        {

            SelectElement selectElement;

            //create select element object, and select
            selectElement = new SelectElement(element);
            selectElement.SelectByText(option);
            Console.WriteLine("Dropdown Selected: " + option);

            return this;
        }
        #endregion
    }
}