using Mars_Competition_Task.Driver;
using NUnit.Framework;
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
        

        private IWebElement signInButton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement email => driver.FindElement(By.Name("email"));
        private IWebElement passowrd => driver.FindElement(By.Name("password"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//*[@class=\"ui large form  \" and @autocomplete=\"on\"]/div[4]/button"));
        private IWebElement loginName => driver.FindElement(By.XPath("//div[contains(text(),\"Ankur Singhal\")]"));

       
        public void SignInFunction(string emailAddress, 
                                    string loginPassword)
            {
            signInButton.Click();
            //email.Click();
            email.SendKeys(emailAddress);
            //passowrd.Click();
            passowrd.SendKeys(loginPassword);
            loginButton.Click();
            Thread.Sleep(3000);
            Assert.That(loginName.Text == "Ankur Singhal", "Login name and username match unsuccessful");
        }
        
    }
} 
