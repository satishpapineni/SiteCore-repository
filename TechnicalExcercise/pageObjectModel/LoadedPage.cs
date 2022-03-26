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
    
    public class LoadedPage
    {
        public IWebDriver driver;
        public LoadedPage(IWebDriver driver)//created a single parameter constructor
        {
            this.driver = driver;//assigning global variable to local variable.
            PageFactory.InitElements(driver,this);//import pageobject package.// allocating driver and memory to that driver.
        }
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'a-spacing-small')]/div/h2/a")]//import page factory package to define webelements.
        IList<IWebElement> urls;
        public void firstUrl()//method created for click first result 
        {
            for (int i = 0; i < urls.Count; i++)
            {
                string expectedLink = urls[i].GetAttribute("href");
                System.Console.WriteLine(expectedLink);
                IWebElement e = urls[i];
                e.Click();
                break;
                if (expectedLink == urls[i].GetAttribute("href"))
                {
                    Assert.Pass();
                }
                else
                {
                    Assert.Fail();
                }

            }
        }

    }
}
