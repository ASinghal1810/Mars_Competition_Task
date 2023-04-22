using Mars_Competition_Task.Driver;
using Mars_Competition_Task.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Competition_Task.Pages
{
    public class HomePage: MarsDriver
    {
        private IWebElement shareSkillButton => driver.FindElement(By.XPath("//*[@class=\"ui eight item menu\"]/div/a"));
        private IWebElement manageListingTbButton => driver.FindElement(By.XPath("//*[@class=\"ui eight item menu\"]/a[3]"));


        public void ShareSkillButton()
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[@class=\"ui eight item menu\"]/div/a");
            shareSkillButton.Click();     
         }

        public void ManageListingTbButton()
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[@class=\"ui eight item menu\"]/a[3]");
            manageListingTbButton.Click();
        }

    }
}
