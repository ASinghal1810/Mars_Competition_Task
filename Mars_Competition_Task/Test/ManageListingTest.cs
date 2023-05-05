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
        }

            [TearDown]
            public void CloseTestRun()
            {
                driver.Quit();
            }
    }
}
