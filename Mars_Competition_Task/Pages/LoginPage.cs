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
        

        private IWebElement signInButton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement email => driver.FindElement(By.Name("email"));
        private IWebElement passowrd => driver.FindElement(By.Name("password"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//*[@class=\"ui large form  \" and @autocomplete=\"on\"]/div[4]/button"));
        
        
            public void SignInButton()
            {
                //signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
                signInButton.Click();

            }
            public void Email()
            {

                email.Click();
                email.SendKeys("ankursinghal9118@gmail.com");

            }
            public void Password()
            {

                passowrd.Click();
                passowrd.SendKeys("Singhal&18");

            }
            public void Login()
            {

                loginButton.Click();
            }
        }
    } 
