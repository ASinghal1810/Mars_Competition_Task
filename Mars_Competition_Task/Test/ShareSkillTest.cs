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

        public ShareSkillTest()
        {

           loginPageObj = new LoginPage();
            homePageObj = new HomePage();
            shareSkillPageObj = new ShareSkillPage();
        }
        

        [Test, Order(1)]
        public void ShareSkillAddition()
        {
           // StartWebsite();
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

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
