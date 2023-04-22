using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Competition_Task.Driver
{
   
    public class MarsDriver
    {
        
        public static IWebDriver driver;


        [SetUp]
        public void StartWebsite()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

    }
}
