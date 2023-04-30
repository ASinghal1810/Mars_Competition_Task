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
            ExtentReporting.LogInfo("Share Skills Action");
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Test Data.xlsx", "Login");         
            loginPageObj.SignInFunction(ExcelLib.ReadData(2, "Username"), ExcelLib.ReadData(2, "Password"));
           // loginPageObj.SignInFunction("ankursinghal9118@gmail.com", "Singhal&18");
            homePageObj.ShareSkillButton();
            ExcelLib.PopulateInCollection(@"C:\Users\ankur\Desktop\Mars_Competition_Task\Mars_Competition_Task\Mars_Competition_Task\Spreadsheets\Share Skill.xlsx", "Sheet1");
            //Pass Parameters String EnterTitle,String EnterDescription, string EnterCategory, string EnterSubCategory, string EnterTag, string EnterSkillExchange, string EnterWorkSamplesLink
            shareSkillPageObj.ShareSkillTest1Addition("1", "2", "3", "4","5","123", "\"C:\\Users\\ankur\\Desktop\\Mars_Competition_Task\\jpg_44.jpg\"");
        }

       

        [Test, Order(2)]
        public void ShareSkillAdditionButCancelSaveOperation()
        {

            
            homePageObj.ShareSkillButton();
          
           
        }

       

    }
}
