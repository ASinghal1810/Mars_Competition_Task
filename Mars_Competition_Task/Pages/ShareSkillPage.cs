using Mars_Competition_Task.Driver;
using Mars_Competition_Task.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using AutoIt;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Mars_Competition_Task.Pages
{
    
    
    public class ShareSkillPage : MarsDriver
    {
        

        private IWebElement titleTextBox => driver.FindElement(By.Name("title"));
        private IWebElement descTestBox => driver.FindElement(By.Name("description"));
        private IWebElement categoryDropDown => driver.FindElement(By.Name("categoryId"));
        private IWebElement subCategoryDropDown => driver.FindElement(By.Name("subcategoryId"));
        private IWebElement tags => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private IWebElement serviceTypeRB => driver.FindElement(By.XPath("//*[@name=\"serviceType\" and @tabindex=\"0\" and @value=\"0\"]"));
        private IWebElement locationTypeRB => driver.FindElement(By.XPath("//*[@name=\"locationType\" and @tabindex=\"0\" and @value=\"0\"]"));
        private IWebElement daysTypeRB => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"0\"]"));
        private IWebElement sTradeTypeRB => driver.FindElement(By.XPath("//input[@name=\"skillTrades\" and @tabindex=\"0\" and @value=\"false\"]"));
        private IWebElement sExchTypeRB => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private IWebElement workSamples => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        private IWebElement saveB => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        
        public void Title()
        {
            //Title
            Wait.WaitToBeClickable("Name", 2, "title");
            titleTextBox.SendKeys("Software Testing");
        }
        public void Description()
        {
            //Description
            Wait.WaitToBeClickable("Name", 2, "description");
            descTestBox.SendKeys("Fresher providing efficient Testing Services for Web Applications");
        }
        public void Category()
        {
            //Category
            SelectElement categorySelect = new SelectElement(categoryDropDown);
            categorySelect.SelectByValue("6");
        }
        public void SubCategory()
        {
            //Sub Category
            Wait.WaitToBeClickable("Name", 2, "categoryId");
            SelectElement subCategorySelect = new SelectElement(subCategoryDropDown);
            //subCategoryDropDown.SendKeys(Keys.Space);
            subCategorySelect.SelectByValue("4");
        }
        public void Tags()
        {
            //Tags
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input");
            tags.SendKeys("Professional" + "\n");
        }
        public void ServiceTypeRB()
        {
            //Service Type Radio Button
            serviceTypeRB.Click();
        }
        public void LocationTypeRB()
        {
            //Location Type
            //Wait.WaitToBeClickable(driver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
            locationTypeRB.Click();
        }
        public void DaysTypeRB()
        {
            // SUnday Button
            // Wait.WaitToBeClickable(driver, "CssSelector", 5, "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div.two.wide.field > div > input[type=checkbox]");
            daysTypeRB.Click();
        }
        public void STradeTypeRB()
        {
            //// Wait.WaitToBeClickable(driver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
            sTradeTypeRB.Click();
        }
        public void SExchTypeRB()
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input");
            Thread.Sleep(3000);
            sExchTypeRB.SendKeys("Professional" + "\n");
            sExchTypeRB.SendKeys("Time Management" + "\n");
            sExchTypeRB.SendKeys("Communication" + "\n");
            sExchTypeRB.SendKeys("Team Player" + "\n");
        }
        public void WorkSamples()
        {
            // Identify the Work Samples and click the plus button to upload photo
            //  Max file size is 2 MB and supported file types are gif / jpeg / png / jpg / doc(x) / pdf / txt / xls(x
            
            workSamples.Click();
            Thread.Sleep(500);
            AutoItX3 autoIt = new AutoItX3();
            Thread.Sleep(500);
            autoIt.WinActivate("Open");
            Thread.Sleep(500);
            autoIt.Send(@"C:\Users\ankur\Desktop\Mars_Competition_Task\jpg_44.jpg");
            Thread.Sleep(500);
            autoIt.Send("{ENTER}");
            Thread.Sleep(500);
        }
        public void SaveButton()
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]");
            saveB.Click();
        }
    }
}
