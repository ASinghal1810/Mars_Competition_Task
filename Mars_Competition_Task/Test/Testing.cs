﻿using Mars_Competition_Task.Driver;
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
    
    public class Testing : MarsDriver
    {
           
        LoginPage loginPageObj;
        HomePage homePageObj;
        ShareSkillPage shareSkillPageObj;
        ManageListingPage manageListingPageObj;

        public Testing()
        {
           loginPageObj = new LoginPage();
            homePageObj = new HomePage();
            shareSkillPageObj = new ShareSkillPage();
            manageListingPageObj = new ManageListingPage();

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
                                                            ExcelLib.ReadData(1, "SundayStartTime"),
                                                            ExcelLib.ReadData(1, "SundayEndTime"),
                                                            ExcelLib.ReadData(1, "Monday"),
                                                            ExcelLib.ReadData(1, "MondayStartTime"),
                                                            ExcelLib.ReadData(1, "MondayEndTime"),
                                                            ExcelLib.ReadData(1, "Tuesday"),
                                                            ExcelLib.ReadData(1, "TuesdayStartTime"),
                                                            ExcelLib.ReadData(1, "TuesdayEndTime"),
                                                            ExcelLib.ReadData(1, "Wednesday"),
                                                            ExcelLib.ReadData(1, "WednesdayStartTime"),
                                                            ExcelLib.ReadData(1, "WednesdayEndTime"),
                                                            ExcelLib.ReadData(1, "Thursday"),
                                                            ExcelLib.ReadData(1, "ThursdayStartTime"),
                                                            ExcelLib.ReadData(1, "ThursdayEndTime"),
                                                            ExcelLib.ReadData(1, "Friday"),
                                                            ExcelLib.ReadData(1, "FridayStartTime"),
                                                            ExcelLib.ReadData(1, "FridayEndTime"),
                                                            ExcelLib.ReadData(1, "Saturday"),
                                                            ExcelLib.ReadData(1, "SaturdayStartTime"),
                                                            ExcelLib.ReadData(1, "SaturdayEndTime"),
                                                            ExcelLib.ReadData(1, "Skill Trade"),
                                                            ExcelLib.ReadData(1, "Skill-Exchange"),
                                                            ExcelLib.ReadData(1, "Credit"),
                                                            ExcelLib.ReadData(1, "WorkSamples"),
                                                            ExcelLib.ReadData(1, "Active"));

            //Checking
            Thread.Sleep(200);
            homePageObj.ManageListingTbButton();
            Thread.Sleep(200);
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
            ExtentReporting.LogInfo("Share Skills Addition Cancel");

            // Login to Mars Portal
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Test Data.xlsx", "Login");
            loginPageObj.SignInFunction(ExcelLib.ReadData(1, "Username"), 
                                        ExcelLib.ReadData(1, "Password"));
            
            //Go To Share Skill Entry Form
            homePageObj.ShareSkillButton();
            //Fill in all fields in Share Skill Form and Save
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Share Skill Test Data.xlsx", "ShareSkill");
            //Pass Parameters String EnterTitle,String EnterDescription, string EnterCategory, string EnterSubCategory, string EnterTag, string EnterSkillExchange, string EnterWorkSamplesLink
            shareSkillPageObj.ShareSkillTest1AdditionCancel(ExcelLib.ReadData(2, "Title"),
                                                            ExcelLib.ReadData(2, "Description"),
                                                            ExcelLib.ReadData(2, "Category"),   
                                                            ExcelLib.ReadData(2, "SubCategory"),
                                                            ExcelLib.ReadData(2, "Tag"),
                                                            ExcelLib.ReadData(2, "ServiceType"),
                                                            ExcelLib.ReadData(1, "LocationType"),
                                                            ExcelLib.ReadData(2, "StartDate"),
                                                            ExcelLib.ReadData(2, "EndDate"),
                                                            ExcelLib.ReadData(2, "Sunday"),
                                                            ExcelLib.ReadData(2, "SundayStartTime"),
                                                            ExcelLib.ReadData(2, "SundayEndTime"),
                                                            ExcelLib.ReadData(2, "Monday"),
                                                            ExcelLib.ReadData(2, "MondayStartTime"),
                                                            ExcelLib.ReadData(2, "MondayEndTime"),
                                                            ExcelLib.ReadData(2, "Tuesday"),
                                                            ExcelLib.ReadData(2, "TuesdayStartTime"),
                                                            ExcelLib.ReadData(2, "TuesdayEndTime"),
                                                            ExcelLib.ReadData(2, "Wednesday"),
                                                            ExcelLib.ReadData(2, "WednesdayStartTime"),
                                                            ExcelLib.ReadData(2, "WednesdayEndTime"),
                                                            ExcelLib.ReadData(2, "Thursday"),
                                                            ExcelLib.ReadData(2, "ThursdayStartTime"),
                                                            ExcelLib.ReadData(2, "ThursdayEndTime"),
                                                            ExcelLib.ReadData(2, "Friday"),
                                                            ExcelLib.ReadData(2, "FridayStartTime"),
                                                            ExcelLib.ReadData(2, "FridayEndTime"),
                                                            ExcelLib.ReadData(2, "Saturday"),
                                                            ExcelLib.ReadData(2, "SaturdayStartTime"),
                                                            ExcelLib.ReadData(2, "SaturdayEndTime"),
                                                            ExcelLib.ReadData(2, "Skill Trade"),
                                                            ExcelLib.ReadData(2, "Skill-Exchange"),
                                                            ExcelLib.ReadData(2, "Credit"),
                                                            ExcelLib.ReadData(2, "WorkSamples"),
                                                            ExcelLib.ReadData(2, "Active"));
            Thread.Sleep(2000);
            //Go To Share Skill Entry Form
            homePageObj.ManageListingTbButton();
            //Fill in all fields in Share Skill Form and Save
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Share Skill Test Data.xlsx", "ShareSkill");
            Thread.Sleep(200);
            shareSkillPageObj.ShareSkillTest2CancelOperationAssertion(ExcelLib.ReadData(2, "Title"));

        }

        [Test, Order(3)]
        public void ShareSkillEdit()
        {

            //Extent Report Start
            ExtentReporting.LogInfo("Share Skills Addition Cancel");

            // Login to Mars Portal
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Test Data.xlsx", "Login");
            loginPageObj.SignInFunction(ExcelLib.ReadData(1, "Username"),
                                        ExcelLib.ReadData(1, "Password"));

            //Go To Share Skill Entry Form
            homePageObj.ManageListingTbButton();
            //Fill in all fields in Share Skill Form and Save
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Manage Lsiting Test Data.xlsx", "ShareSkill");
            //Pass Parameters String EnterTitle,String EnterDescription, string EnterCategory, string EnterSubCategory, string EnterTag, string EnterSkillExchange, string EnterWorkSamplesLink
            manageListingPageObj.UpdateShareSkill(ExcelLib.ReadData(1, "Title"),
                                                            ExcelLib.ReadData(1, "Description"),
                                                            ExcelLib.ReadData(1, "Category"),
                                                            ExcelLib.ReadData(1, "SubCategory"),
                                                            ExcelLib.ReadData(1, "Tag"),
                                                            ExcelLib.ReadData(1, "ServiceType"),
                                                            ExcelLib.ReadData(1, "LocationType"),
                                                            ExcelLib.ReadData(1, "StartDate"),
                                                            ExcelLib.ReadData(1, "EndDate"),
                                                            ExcelLib.ReadData(1, "Sunday"),
                                                            ExcelLib.ReadData(1, "SundayStartTime"),
                                                            ExcelLib.ReadData(1, "SundayEndTime"),
                                                            ExcelLib.ReadData(1, "Monday"),
                                                            ExcelLib.ReadData(1, "MondayStartTime"),
                                                            ExcelLib.ReadData(1, "MondayEndTime"),
                                                            ExcelLib.ReadData(1, "Tuesday"),
                                                            ExcelLib.ReadData(1, "TuesdayStartTime"),
                                                            ExcelLib.ReadData(1, "TuesdayEndTime"),
                                                            ExcelLib.ReadData(1, "Wednesday"),
                                                            ExcelLib.ReadData(1, "WednesdayStartTime"),
                                                            ExcelLib.ReadData(1, "WednesdayEndTime"),
                                                            ExcelLib.ReadData(1, "Thursday"),
                                                            ExcelLib.ReadData(1, "ThursdayStartTime"),
                                                            ExcelLib.ReadData(1, "ThursdayEndTime"),
                                                            ExcelLib.ReadData(1, "Friday"),
                                                            ExcelLib.ReadData(1, "FridayStartTime"),
                                                            ExcelLib.ReadData(1, "FridayEndTime"),
                                                            ExcelLib.ReadData(1, "Saturday"),
                                                            ExcelLib.ReadData(1, "SaturdayStartTime"),
                                                            ExcelLib.ReadData(1, "SaturdayEndTime"),
                                                            ExcelLib.ReadData(1, "Skill Trade"),
                                                            ExcelLib.ReadData(1, "Skill-Exchange"),
                                                            ExcelLib.ReadData(1, "Credit"),
                                                            ExcelLib.ReadData(1, "WorkSamples"),
                                                            ExcelLib.ReadData(1, "Active"));

            //Go To Share Skill Entry Form
            homePageObj.ManageListingTbButton();
            //Fill in all fields in Share Skill Form and Save
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Manage Lsiting Test Data.xlsx", "ShareSkill");
            manageListingPageObj.EditSkillAssertion(ExcelLib.ReadData(1, "Title"),
                                                            ExcelLib.ReadData(1, "Description"),
                                                            ExcelLib.ReadData(1, "CategoryDescription"),
                                                            ExcelLib.ReadData(1, "ServiceType"));
        
        }

        [Test, Order(4)]
        public void ShareSkillDelete()
        {
            //Extent Report Start
            ExtentReporting.LogInfo("Share Skills Addition Cancel");

            // Login to Mars Portal
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Test Data.xlsx", "Login");
            loginPageObj.SignInFunction(ExcelLib.ReadData(1, "Username"),
                                        ExcelLib.ReadData(1, "Password"));

            //Go To Share Skill Entry Form
            homePageObj.ManageListingTbButton();
            //Fill in all fields in Share Skill Form and Save
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Manage Lsiting Test Data.xlsx", "ShareSkill");
            //Pass Parameters String EnterTitle,String EnterDescription, string EnterCategory, string EnterSubCategory, string EnterTag, string EnterSkillExchange, string EnterWorkSamplesLink
            manageListingPageObj.DeleateListing();
            manageListingPageObj.DeleteSkillAssertion(ExcelLib.ReadData(1, "Title"));
        }


    }
}
