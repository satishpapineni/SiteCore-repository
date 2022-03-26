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
    public class FinalValidation
    {
        public IWebDriver driver;
        public FinalValidation(IWebDriver driver)//created a single parameter constructor
        {
            this.driver = driver;//assigning global variable to local variable.
            PageFactory.InitElements(driver,this);//import pageobject package.// allocating driver and memory to that driver.
        }
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'a-spacing-micro')]/span[1]/span[2]")]//import page factory package to define webelements.
        IWebElement element;
        public void getFinalValidation()//comparing the price value
        {
            int actualValue = 100;// input value in interger
            var  output=  element.Text;// geting output value in string
            Console.WriteLine(output);
            string newOutput = output.Split("$")[1];// split the string value value and assign the second array to newOutput
            decimal seperstedValue=Convert.ToDecimal(newOutput);//newOut converted to decimalform.
            int expectedValue=Convert.ToInt32(seperstedValue);//covert decimal to int.
            Console.WriteLine(expectedValue);
            Console.WriteLine(seperstedValue);
            Console.WriteLine(newOutput);


            if(expectedValue > actualValue)//comapring both input and out 
            {
                Assert.Pass(newOutput);
            }
            else
            {
                Assert.Fail(newOutput);
            }

            

        }

    }
}
