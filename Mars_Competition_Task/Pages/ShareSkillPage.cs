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
using Excel = Microsoft.Office.Interop.Excel;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using AventStack.ExtentReports.Utils;
using Microsoft.CodeAnalysis.Text;

namespace Mars_Competition_Task.Pages
{
    
    
    public class ShareSkillPage : MarsDriver
    {
        
        
        private IWebElement titleTextBox => driver.FindElement(By.Name("title"));
        private IWebElement descTestBox => driver.FindElement(By.Name("description"));
        private IWebElement categoryDropDown => driver.FindElement(By.Name("categoryId"));
        private IWebElement subCategoryDropDown => driver.FindElement(By.Name("subcategoryId"));
        private IWebElement tags => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private IWebElement serviceTypeHourlyRB => driver.FindElement(By.XPath("//*[@name=\"serviceType\" and @tabindex=\"0\" and @value=\"0\"]"));
        private IWebElement serviceTypeOneOffRB => driver.FindElement(By.XPath("//*[@name=\"serviceType\" and @tabindex=\"0\" and @value=\"1\"]"));
        private IWebElement locationTypeOnSiteRB => driver.FindElement(By.XPath("//*[@name=\"locationType\" and @tabindex=\"0\" and @value=\"0\"]"));
        private IWebElement locationTypeOnlineRB => driver.FindElement(By.XPath("//*[@name=\"locationType\" and @tabindex=\"0\" and @value=\"1\"]"));
        private IWebElement startDate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
        private IWebElement endDate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
        private IWebElement sunday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"0\"]"));
        private IWebElement sundayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"0\"]"));
        private IWebElement sundayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"0\"]"));
        private IWebElement monday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"1\"]"));
        private IWebElement mondayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"1\"]"));
        private IWebElement mondayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"1\"]"));
        private IWebElement tuesday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"2\"]"));
        private IWebElement tuesdayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"2\"]"));
        private IWebElement tuesdayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"2\"]"));
        private IWebElement wednesday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"3\"]"));
        private IWebElement wednesdayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"3\"]"));
        private IWebElement wednesdayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"3\"]"));
        private IWebElement thursday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"4\"]"));
        private IWebElement thursdayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"4\"]"));
        private IWebElement thursdayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"4\"]"));
        private IWebElement friday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"5\"]"));
        private IWebElement fridayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"5\"]"));
        private IWebElement fridayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"5\"]"));
        private IWebElement saturday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"6\"]"));
        private IWebElement saturdayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"6\"]"));
        private IWebElement saturdayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"6\"]"));
        private IWebElement sTradeTypeRB => driver.FindElement(By.XPath("//input[@name=\"skillTrades\" and @tabindex=\"0\" and @value=\"false\"]"));
        private IWebElement credit => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input"));
        private IWebElement sExch => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private IWebElement workSamples => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        private IWebElement saveB => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        private IWebElement cancelB => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[2]"));
        private IWebElement titleText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        private IWebElement descriptionText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
        private IWebElement categoryText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]"));
        private IWebElement serviceTypeText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[5]"));
        
        public void ShareSkillTest1Addition(String EnterTitle,
                                            String EnterDescription,
                                            string EnterCategory,
                                            string EnterSubCategory,
                                            string EnterTag,
                                            string ServiceType,
                                            string LocationType,
                                            string SsStartDate,
                                            string SsEndDate,
                                            string SsSunday,
                                            string SsSundayST,
                                            string SsSundayET,
                                            string SsMonday,
                                            string SsMondayST,
                                            string SsMondayET,
                                            string SsTuesday,
                                            string SsTuesdayST,
                                            string SsTuesdayET,
                                            string SsWednesday,
                                            string SsWednesdayST,
                                            string SsWednesdayET,
                                            string SsThursday,
                                            string SsThursdayST,
                                            string SsThursdayET,
                                            string SsFriday,
                                            string SsFridayST,
                                            string SsFridayET,
                                            string SsSaturday,
                                            string SsSaturdayST,
                                            string SsSaturdayET,
                                            string EnterSkillTrade,
                                            string EnterSkillExchange,
                                            string SsCredit,
                                            string EnterWorkSamplesLink,
                                            string Active)
        {
            Thread.Sleep(3000);
            //Title
            Wait.WaitToBeClickable("Name", 10, "title");
            titleTextBox.SendKeys(EnterTitle);
            Thread.Sleep(3000);
            //Description
            Wait.WaitToBeClickable("Name", 10, "description");
            descTestBox.SendKeys(EnterDescription);
            Thread.Sleep(3000);
            //Category
            SelectElement categorySelect = new SelectElement(categoryDropDown);
            categorySelect.SelectByValue(EnterCategory);
            Thread.Sleep(3000);
            //Sub Category
            Wait.WaitToBeClickable("Name", 10, "categoryId");
            SelectElement subCategorySelect = new SelectElement(subCategoryDropDown);
            //subCategoryDropDown.SendKeys(Keys.Space);
            subCategorySelect.SelectByValue(EnterSubCategory);
            Thread.Sleep(3000);
            //Tags
            Wait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input");
            tags.SendKeys(EnterTag + "\n");
            Thread.Sleep(3000);
            //Service Type Radio Button
            if (ServiceType == "Hourly")
            {
                serviceTypeHourlyRB.Click();
            }
            else
            {
                serviceTypeOneOffRB.Click();
            }
            Thread.Sleep(3000);
            //Location Type
            //Wait.WaitToBeClickable(driver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
            if (LocationType == "Online")
            {
                locationTypeOnSiteRB.Click();
            }
            else
            {
                locationTypeOnlineRB.Click();
            }
            Thread.Sleep(1000);

            //Start Date
            startDate.SendKeys(SsStartDate);

            //End Date
            if(SsEndDate!=null)
            {
                endDate.SendKeys(SsEndDate);
            }

            // Sunday Button
            if (SsSunday == "Active")
            {
                sunday.Click();
                sundayST.SendKeys(SsSundayST);
                sundayST.SendKeys(SsSundayET);
            }

            // Monday Button
            if (SsMonday == "Active")
            {
                monday.Click();
                mondayST.SendKeys(SsMondayST);
                mondayET.SendKeys(SsMondayET);

            }

            // Tuesday Button
            if (SsTuesday == "Active")
            {
                tuesday.Click();
                tuesdayST.SendKeys(SsTuesdayST);
                tuesdayET.SendKeys(SsTuesdayET);

            }

            // Wednesday Button
            if (SsWednesday == "Active")
            {
                wednesday.Click();
                wednesdayST.SendKeys(SsWednesdayST);
                wednesdayET.SendKeys(SsWednesdayET);

            }

            // Thursday Button
            if (SsThursday == "Active")
            {
                thursday.Click();
                thursdayST.SendKeys(SsThursdayST);
                thursdayET.SendKeys(SsThursdayET);

            }

            // Friday Button
            if (SsFriday == "Active")
            {
                friday.Click();
                fridayST.SendKeys(SsFridayST);
                fridayET.SendKeys(SsFridayET);

            }

            // Saturday Button
            if (SsSaturday == "Active")
            {
                saturday.Click();
                saturdayST.SendKeys(SsSaturdayST);
                saturdayET.SendKeys(SsSaturdayET);

            }
            Thread.Sleep(3000);
            //Wait.WaitToBeClickable(driver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
            sTradeTypeRB.Click();
            Thread.Sleep(3000);
            //Credit Or Skill-Exchange
            if(EnterSkillTrade=="Skill-Exchange")
            {
                sExch.Click();
                sExch.SendKeys(EnterSkillExchange);
                sExch.SendKeys("\n");
            }
            else
            {
                credit.Click();
                credit.SendKeys(SsCredit);
                credit.SendKeys("\n");
            }
            
            
           
            //////Skill Exchange
            //Wait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input");
            //Thread.Sleep(3000);
            //sExchTypeRB.SendKeys(EnterSkillExchange + "\n");
           
            Thread.Sleep(3000);
            //Work Samples
            // Identify the Work Samples and click the plus button to upload photo
            //  Max file size is 2 MB and supported file types are gif / jpeg / png / jpg / doc(x) / pdf / txt / xls(x
            Thread.Sleep(3000);
            workSamples.Click();
            Thread.Sleep(500);
            AutoItX3 autoIt = new AutoItX3();
            Thread.Sleep(500);
            autoIt.WinActivate("Open");
            Thread.Sleep(500);
            autoIt.Send(EnterWorkSamplesLink);
            Thread.Sleep(500);
            autoIt.Send("{ENTER}");
            Thread.Sleep(500);
            
            //SaveButton
            Wait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]");
            saveB.Click();
        }
        public void ShareSkillTest1AdditionAssertion(String EnterTitle, 
                                                        String EnterDescription,
                                                        string EnterCategory,
                                                        string EnterServiceType)
        {

            Thread.Sleep(500);
            Assert.That(titleText.Text == EnterTitle, " Title match unsuccessful");
            Thread.Sleep(500);
            Assert.That(descriptionText.Text == EnterDescription, "Description match unsuccessful");
            Thread.Sleep(500);
            Assert.That(categoryText.Text == EnterCategory, "Category match unsuccessful");
            Thread.Sleep(500);
            Assert.That(serviceTypeText.Text == EnterServiceType, "Service Type match unsuccessful");
           
        }
        public void ShareSkillTest1AdditionCancel(String EnterTitle,
                                            String EnterDescription,
                                            string EnterCategory,
                                            string EnterSubCategory,
                                            string EnterTag,
                                            string ServiceType,
                                            string LocationType,
                                            string SsStartDate,
                                            string SsEndDate,
                                            string SsSunday,
                                            string SsSundayST,
                                            string SsSundayET,
                                            string SsMonday,
                                            string SsMondayST,
                                            string SsMondayET,
                                            string SsTuesday,
                                            string SsTuesdayST,
                                            string SsTuesdayET,
                                            string SsWednesday,
                                            string SsWednesdayST,
                                            string SsWednesdayET,
                                            string SsThursday,
                                            string SsThursdayST,
                                            string SsThursdayET,
                                            string SsFriday,
                                            string SsFridayST,
                                            string SsFridayET,
                                            string SsSaturday,
                                            string SsSaturdayST,
                                            string SsSaturdayET,
                                            string EnterSkillTrade,
                                            string EnterSkillExchange,
                                            string SsCredit,
                                            string EnterWorkSamplesLink,
                                            string Active)
        {

            Thread.Sleep(3000);
            //Title
            Wait.WaitToBeClickable("Name", 10, "title");
            titleTextBox.SendKeys(EnterTitle);
            Thread.Sleep(3000);
            //Description
            Wait.WaitToBeClickable("Name", 10, "description");
            descTestBox.SendKeys(EnterDescription);
            Thread.Sleep(3000);
            //Category
            SelectElement categorySelect = new SelectElement(categoryDropDown);
            categorySelect.SelectByValue(EnterCategory);
            Thread.Sleep(3000);
            //Sub Category
            Wait.WaitToBeClickable("Name", 10, "categoryId");
            SelectElement subCategorySelect = new SelectElement(subCategoryDropDown);
            //subCategoryDropDown.SendKeys(Keys.Space);
            subCategorySelect.SelectByValue(EnterSubCategory);
            Thread.Sleep(3000);
            //Tags
            Wait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input");
            tags.SendKeys(EnterTag + "\n");
            Thread.Sleep(3000);
            //Service Type Radio Button
            if (ServiceType == "Hourly")
            {
                serviceTypeHourlyRB.Click();
            }
            else
            {
                serviceTypeOneOffRB.Click();
            }
            Thread.Sleep(3000);
            //Location Type
            //Wait.WaitToBeClickable(driver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
            if (LocationType == "Online")
            {
                locationTypeOnSiteRB.Click();
            }
            else
            {
                locationTypeOnlineRB.Click();
            }
            Thread.Sleep(1000);

            //Start Date
            startDate.SendKeys(SsStartDate);

            //End Date
            if (SsEndDate != null)
            {
                endDate.SendKeys(SsEndDate);
            }

            // Sunday Button
            if (SsSunday == "Active")
            {
                sunday.Click();

            }

            // Monday Button
            if (SsMonday == "Active")
            {
                monday.Click();
            }

            // Tuesday Button
            if (SsTuesday == "Active")
            {
                tuesday.Click();
            }

            // Wednesday Button
            if (SsWednesday == "Active")
            {
                wednesday.Click();
            }

            // Thursday Button
            if (SsThursday == "Active")
            {
                thursday.Click();
            }

            // Friday Button
            if (SsFriday == "Active")
            {
                friday.Click();
            }

            // Saturday Button
            if (SsSaturday == "Active")
            {
                saturday.Click();
            }
            Thread.Sleep(3000);
            //Wait.WaitToBeClickable(driver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
            sTradeTypeRB.Click();
            Thread.Sleep(3000);
            //Credit Or Skill-Exchange
            if (EnterSkillTrade == "Skill-Exchange")
            {
                sExch.Click();
                sExch.SendKeys(EnterSkillExchange);
                sExch.SendKeys("\n");
            }
            else
            {
                credit.Click();
                credit.SendKeys(SsCredit);
                credit.SendKeys("\n");
            }



            //////Skill Exchange
            //Wait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input");
            //Thread.Sleep(3000);
            //sExchTypeRB.SendKeys(EnterSkillExchange + "\n");

            Thread.Sleep(3000);
            //Work Samples
            // Identify the Work Samples and click the plus button to upload photo
            //  Max file size is 2 MB and supported file types are gif / jpeg / png / jpg / doc(x) / pdf / txt / xls(x
            Thread.Sleep(3000);
            workSamples.Click();
            Thread.Sleep(500);
            AutoItX3 autoIt = new AutoItX3();
            Thread.Sleep(500);
            autoIt.WinActivate("Open");
            Thread.Sleep(500);
            autoIt.Send(EnterWorkSamplesLink);
            Thread.Sleep(500);
            autoIt.Send("{ENTER}");
            Thread.Sleep(500);

            //CancelButton
            Wait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[2]");
            cancelB.Click();
        }
    }
}
