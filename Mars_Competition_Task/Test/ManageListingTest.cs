using CompetitionTask.Utilites;
using Mars_Competition_Task.Driver;
using Mars_Competition_Task.Pages;
using NUnit.Framework;
using ReportUtils.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mars_Competition_Task.Test
{
    [TestFixture]
    [Parallelizable]
    public class ManageListingTest: MarsDriver
    {

        //Page Object Initialization and Definition
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        ManageListingPage manageListingPageObj= new ManageListingPage();

       

            [Test, Order(1)]
            public void ShareSkillEdit()
            {

            //Extent Report Start
            ExtentReporting.LogInfo("Share Skills Action");

            // Login to Mars Portal
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Test Data.xlsx", "Login");
            loginPageObj.SignInFunction(ExcelLib.WriteData(1, "Username"), ExcelLib.WriteData(1, "Password"));

            //Go To Share Skill Entry Form
            homePageObj.ShareSkillButton();

            //Fill in all fields in Share Skill Form and Save
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Share Skill Test Data.xlsx", "ShareSkill");
            //Pass Parameters String EnterTitle,String EnterDescription, string EnterCategory, string EnterSubCategory, string EnterTag, string EnterSkillExchange, string EnterWorkSamplesLink
            manageListingPageObj.UpdateShareSkill(ExcelLib.WriteData(1, "Title"), ExcelLib.WriteData(1, "Description"), ExcelLib.WriteData(1, "Category"), ExcelLib.WriteData(1, "Sub Category"), ExcelLib.WriteData(1, "Tag"), ExcelLib.WriteData(1, "Credit"), ExcelLib.WriteData(1, "Work Samples"));
        }

            [TearDown]
            public void CloseTestRun()
            {
                driver.Quit();
            }
    }
}
