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

namespace Mars_Competition_Task.Pages
{
    public class ShareSkillPage : MarsDriver
    {
        public IWebElement titleTextBox;
        public IWebElement descTestBox;
        public IWebElement categoryDropDown;
        public IWebElement subCategoryDropDown;
        public IWebElement tags;
        public IWebElement serviceTypeRB;
        public IWebElement locationTypeRB;
        public IWebElement daysTypeRB;
        public IWebElement sExchTypeRB;
        public IWebElement workSamples;
        public SelectElement categorySelect;
        public SelectElement subCategorySelect;

        public void MarsShareSkillsForm()
        { 
            //Title
            Wait.WaitToBeClickable("Name", 2, "title");
            titleTextBox = driver.FindElement(By.Name("title"));
            titleTextBox.SendKeys("Software Testing");

            //Description
            Wait.WaitToBeClickable("Name", 2, "description");
            descTestBox = driver.FindElement(By.Name("description"));
            descTestBox.SendKeys("Fresher providing efficient Testing Services for Web Applications");

            //Category
            categoryDropDown=driver.FindElement(By.Name("categoryId"));
            categorySelect = new SelectElement(categoryDropDown);
            categorySelect.SelectByValue("6");

            //Sub Category
            Wait.WaitToBeClickable("Name", 2, "categoryId");
            subCategoryDropDown = driver.FindElement(By.Name("subcategoryId"));
            subCategoryDropDown.SendKeys(Keys.Space);
            subCategorySelect = new SelectElement(driver.FindElement(By.Name("subcategoryId")));
            subCategorySelect.SelectByValue("4");

            //Tags
            Wait.WaitToBeClickable("Name", 2, "subcategoryId");
            tags = driver.FindElement(By.Name("subcategoryId"));
            tags.SendKeys("Professional" + "\n");



            //Service Type Radio Button
            serviceTypeRB = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(5) > div.twelve.wide.column > div.inline.fields > div:nth-child(2) > div > input[type=radio]"));
            serviceTypeRB.Click();



            //Wait.WaitToBeClickable(driver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
            locationTypeRB = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(6) > div.twelve.wide.column > div > div:nth-child(1) > div > input[type=radio]"));
            locationTypeRB.Click();

            // Wait.WaitToBeClickable(driver, "CssSelector", 5, "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div.two.wide.field > div > input[type=checkbox]");
            daysTypeRB = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div.two.wide.field > div > input[type=checkbox]"));
            daysTypeRB.Click();

            //// Wait.WaitToBeClickable(driver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
            //IWebElement sTradeTypeRB = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(2) > div > div:nth-child(2) > div > input[type=radio]"));
            //sTradeTypeRB.Click();

            Wait.WaitToBeClickable("XPath", 5, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input");
            Thread.Sleep(3000);
            sExchTypeRB = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            sExchTypeRB.SendKeys("Professional" + "\n");
            sExchTypeRB.SendKeys("Time Management" + "\n");
            sExchTypeRB.SendKeys("Communication" + "\n");
            sExchTypeRB.SendKeys("Team Player" + "\n");

            // Identify the Work Samples and click the plus button to upload photo
            workSamples = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
            workSamples.Click();

           // Process.Start("C:\\Users\\ankur\\Desktop\\Mars_Competition_Task\\FileUpload.exe");
            //  Max file size is 2 MB and supported file types are gif / jpeg / png / jpg / doc(x) / pdf / txt / xls(x

            Thread.Sleep(5000);

            AutoItX3 autoIt = new AutoItX3();
            Thread.Sleep(5000);
            autoIt.WinActivate("Open");
            Thread.Sleep(5000);
            autoIt.Send(@"C:\Users\ankur\Desktop\Mars_Competition_Task\jpg_44.jpg");
            Thread.Sleep(5000);
            autoIt.Send("{ENTER}");
            Thread.Sleep(5000);
            Wait.WaitToBeClickable("XPath", 5, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]");
            IWebElement saveB = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            saveB.Click();
        }
    }
}
