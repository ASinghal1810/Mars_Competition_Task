using Mars_Competition_Task.Driver;
using Mars_Competition_Task.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Competition_Task.Test
{
    
    [TestFixture]
    [Parallelizable]
    
    public class ShareSkillTest : MarsDriver
    {
           
        LoginPage loginPageObj;
        HomePage homePageObj;
        ShareSkillPage shareSkillPageObj;
        private static string FILENAME;


        public ShareSkillTest()
        {

           loginPageObj = new LoginPage();
            homePageObj = new HomePage();
            shareSkillPageObj = new ShareSkillPage();
            FILENAME = "Registeration_Data.xlsx";

        }
        

        [Test, Order(1)]
        public void ShareSkillAddition()
        {
           
            loginPageObj.SignInButton();
            loginPageObj.Email();
            loginPageObj.Password();
            loginPageObj.Login();
            homePageObj.ShareSkillButton();
            shareSkillPageObj.Title();
            shareSkillPageObj.Description();
            shareSkillPageObj.Category();
            shareSkillPageObj.SubCategory();
            shareSkillPageObj.Tags();
            shareSkillPageObj.ServiceTypeRB();
            shareSkillPageObj.LocationTypeRB();
            shareSkillPageObj.SExchTypeRB();
            shareSkillPageObj.WorkSamples();
            shareSkillPageObj.SaveButton();
        }
        [Test, Order(2)]
        public void ShareSkillAdditionButCancelSaveOperation()
        {

            loginPageObj.SignInButton();
            loginPageObj.Email();
            loginPageObj.Password();
            loginPageObj.Login();
            homePageObj.ShareSkillButton();
            shareSkillPageObj.Title();
            shareSkillPageObj.Description();
            shareSkillPageObj.Category();
            shareSkillPageObj.SubCategory();
            shareSkillPageObj.Tags();
            shareSkillPageObj.ServiceTypeRB();
            shareSkillPageObj.LocationTypeRB();
            shareSkillPageObj.SExchTypeRB();
            shareSkillPageObj.WorkSamples();
            shareSkillPageObj.CancelButton();
        }

        [TestCaseSource("RegisrtrationData")]
        public void CheckName_Validations(string name, string email, string phone, string password)
        {
            Assert.Multiple(() =>
            {
                Assert.IsNotEmpty(name);
               
            });
        }
        public static IEnumerable<TestCaseData> RegisrtrationData()
        {
            return ExcelReader.ReadFromExcel(FILENAME, "Registeration");
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
