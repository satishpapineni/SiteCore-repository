using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechnicalExcercise.pageObjectModel;
using TechnicalExcercise.utilities;
using WebDriverManager.DriverConfigs.Impl;

namespace TechnicalExcercise
{
    public class Tests : Base
    {
        

        [Test]
        public void Test1()
        {
            LaptopPage p = new LaptopPage(getDriver());// intializing memory for Laptop class and calling getdriver method.
            p.selectFirstProduct();//calling a method with reference p
            LoadedPage l=new LoadedPage(getDriver());//intializing Memory for Loadpage class
            l.firstUrl();//calling a method with refference l
            FinalValidation f=new  FinalValidation(getDriver());
            f.getFinalValidation();
            Assert.Pass();
        }
    }
}