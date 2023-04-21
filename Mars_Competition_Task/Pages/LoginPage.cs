using Mars_Competition_Task.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Competition_Task.Pages
{
    public class LoginPage : MarsDriver
    {
        public void LoginSteps() 
        {
            driver.FindElement(By.XPath("//*[@class=\"right item\"]/a")).Click();
            driver.FindElement(By.Name("email")).Click();
            driver.FindElement(By.Name("email")).SendKeys("ankursinghal9118@gmail.com");
            driver.FindElement(By.Name("password")).Click();
            driver.FindElement(By.Name("password")).SendKeys("Singhal&18");
            driver.FindElement(By.XPath("//*[@class=\"ui large form  \" and @autocomplete=\"on\"]/div[4]/button")).Click(); 
        }
    }
}
