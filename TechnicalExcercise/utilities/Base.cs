using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace TechnicalExcercise.utilities
{
    public class Base
    {
        string actualUrl = "https://www.amazon.com/";//intializing url to a varaiable
        public IWebDriver driver;// making driver as a public for global use
        [SetUp]
       
        public void Setup()
        {
          string browserName = ConfigurationManager.AppSettings["browser"];//import ConfigurationManager package and give acces to app.config file to access the key, value from app.config file
            InItBrowser(browserName);//calling method with single parameter
            driver.Manage().Window.Maximize();//maximizing the chrome window
            driver.Navigate().GoToUrl(actualUrl); //passing url variable to hit the chrome
            string expectedUrl = driver.Url;// calling url and assigning to the variable
            Console.WriteLine(actualUrl);//printing the variable
            Console.WriteLine(expectedUrl);
            Assert.AreEqual(expectedUrl, actualUrl);//comparing both urls
        }
        public void InItBrowser(string browserName)// method with single paramter
        {
            switch (browserName)//sending the broswername variable
            {
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());//import webdrivermanager package and setup the driver to chrome
                    driver = new ChromeDriver();//intializing memeory allocation to driver
                    break;
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());//import webdrivermanager package and setup the driver to Firefox
                    driver = new FirefoxDriver();//intializing memeory allocation to driver
                    break;

                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());//import webdrivermanager package and setup the driver to Edge
                    driver = new EdgeDriver();//intializing memeory allocation to driver
                    break;

            }
        }
        public IWebDriver getDriver()//created a method which i need to send driver to other classes
        {
            return driver;
        }
        [TearDown]
        public void shutDownBrowser()
        {
           // driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(3);//giving implicit wait to see the final result before closing the chrome/edge/firefox. 
            //Thread.Sleep(8000);
            driver.Close();// finally close the driver at the end.
        }

    }
}
