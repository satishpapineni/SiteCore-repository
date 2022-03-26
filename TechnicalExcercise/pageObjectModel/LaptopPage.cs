using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalExcercise.pageObjectModel
{
    public class LaptopPage
    {
        public IWebDriver driver;
        public LaptopPage(IWebDriver driver)//created a single parameter constructor
        {
            this.driver = driver;//assigning global variable to local variable.
            PageFactory.InitElements(driver,this);//import pageobject package.// allocating driver and memory to that driver.
        }
        [FindsBy(How = How.XPath, Using = "//input[@id='twotabsearchtextbox']")]//import page factory package to define webelements.
        IWebElement searchBox;
        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        IWebElement searchButton;
        public void selectFirstProduct()//created a method to send the values.
        {
           // bool textBox=searchBox.Enabled;
            if(searchBox.Enabled)//if searchbox is enable the it goes inside and send the values and click the seacrh button.
            {
                searchBox.SendKeys("laptop");
                searchButton.Click();
               
            }
            else
            {
                Console.WriteLine("failed");
            }
            
        }
    }
}
