using Mars_Competition_Task.Driver;
using Mars_Competition_Task.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_Competition_Task.Utility;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using ReportUtils.Reports;
using CompetitionTask.Utilites;
using OpenQA.Selenium;

namespace Mars_Competition_Task.Test
{
    
    [TestFixture]
    [Parallelizable]
    
    public class ShareSkillTest : MarsDriver
    {
           
        LoginPage loginPageObj;
        HomePage homePageObj;
        ShareSkillPage shareSkillPageObj;

        


        public ShareSkillTest()
        {
           loginPageObj = new LoginPage();
            homePageObj = new HomePage();
            shareSkillPageObj = new ShareSkillPage();

            
        }
        

        [Test, Order(1)]
        public void ShareSkillAddition()
        {
            //Extent Report Start
            ExtentReporting.LogInfo("Share Skills Action");

            // Login to Mars Portal
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Test Data.xlsx", "Login"); 
            loginPageObj.SignInFunction(ExcelLib.ReadData(1, "Username"), 
                                        ExcelLib.ReadData(1, "Password"));
            

            //Go To Share Skill Entry Form
            homePageObj.ShareSkillButton();          

            //Fill in all fields in Share Skill Form and Save
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Share Skill Test Data.xlsx", "ShareSkill");
            //Pass Parameters String EnterTitle,String EnterDescription, string EnterCategory, string EnterSubCategory, string EnterTag, string EnterSkillExchange, string EnterWorkSamplesLink
            shareSkillPageObj.ShareSkillTest1Addition(ExcelLib.ReadData(1, "Title"), 
                                                        ExcelLib.ReadData(1, "Description"), 
                                                        ExcelLib.ReadData(1, "Category"), 
                                                        ExcelLib.ReadData(1, "SubCategory"), 
                                                        ExcelLib.ReadData(1, "Tag"),
                                                        ExcelLib.ReadData(1, "ServiceType"),
                                                        ExcelLib.ReadData(1, "LocationType"),
                                                        ExcelLib.ReadData(1, "StartDate"),
                                                        ExcelLib.ReadData(1, "EndDate"),
                                                        ExcelLib.ReadData(1, "Sunday"),
                                                        ExcelLib.ReadData(1, "Monday"),
                                                        ExcelLib.ReadData(1, "Tuesday"),
                                                        ExcelLib.ReadData(1, "Wednesday"),
                                                        ExcelLib.ReadData(1, "Thursday"),
                                                        ExcelLib.ReadData(1, "Friday"),
                                                        ExcelLib.ReadData(1, "Saturday"),
                                                        ExcelLib.ReadData(1, "Credit"), 
                                                        ExcelLib.ReadData(1, "WorkSamples"));

            //Checking
            Thread.Sleep(2000);
            homePageObj.ManageListingTbButton();
            Thread.Sleep(2000);
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Share Skill Test Data.xlsx", "ShareSkill");
            //Pass Parameters String EnterTitle,String EnterDescription, string EnterCategory, string EnterSubCategory, string EnterTag, string EnterSkillExchange, string EnterWorkSamplesLink
            shareSkillPageObj.ShareSkillTest1AdditionAssertion(ExcelLib.ReadData(1, "Title"), 
                                                                ExcelLib.ReadData(1, "Description"), 
                                                                ExcelLib.ReadData(1, "CategoryDescription"), 
                                                                ExcelLib.ReadData(1, "ServiceType"));
        }                                                                                                                                                  

       

        [Test, Order(2)]
        public void ShareSkillAdditionButCancelSaveOperation()
        {
            //Extent Report Start
            ExtentReporting.LogInfo("Share Skills Action");

            // Login to Mars Portal
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Test Data.xlsx", "Login");
            loginPageObj.SignInFunction(ExcelLib.ReadData(1, "Username"), 
                                        ExcelLib.ReadData(1, "Password"));
            
            //Go To Share Skill Entry Form
            homePageObj.ShareSkillButton();
            //Fill in all fields in Share Skill Form and Save
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Share Skill Test Data.xlsx", "ShareSkill");
            //Pass Parameters String EnterTitle,String EnterDescription, string EnterCategory, string EnterSubCategory, string EnterTag, string EnterSkillExchange, string EnterWorkSamplesLink
            shareSkillPageObj.ShareSkillTest1AdditionCancel(ExcelLib.ReadData(1, "Title"), 
                                                            ExcelLib.ReadData(1, "Description"), 
                                                            ExcelLib.ReadData(1, "Category"), 
                                                            ExcelLib.ReadData(1, "Sub Category"), 
                                                            ExcelLib.ReadData(1, "Tag"),
                                                            ExcelLib.ReadData(1, "ServiceType"),
                                                            ExcelLib.ReadData(1, "LocationType"),
                                                            ExcelLib.ReadData(1, "StartDate"),
                                                            ExcelLib.ReadData(1, "EndDate"),
                                                            ExcelLib.ReadData(1, "Sunday"),
                                                            ExcelLib.ReadData(1, "Monday"),
                                                            ExcelLib.ReadData(1, "Tuesday"),
                                                            ExcelLib.ReadData(1, "Wednesday"),
                                                            ExcelLib.ReadData(1, "Thursday"),
                                                            ExcelLib.ReadData(1, "Friday"),
                                                            ExcelLib.ReadData(1, "Saturday"),
                                                            ExcelLib.ReadData(1, "Credit"), 
                                                            ExcelLib.ReadData(1, "WorkSamples"));
        }



    }
}
