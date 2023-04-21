using Mars_Competition_Task.Driver;
using Mars_Competition_Task.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Competition_Task.Test
{
    [TestFixture]
    [Parallelizable]
    public class ShareSkillTest : MarsDriver
    {//
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        ShareSkillPage shareSkillPageObj = new ShareSkillPage();



        [Test, Order(1)]
        public void ShareSkillAddition()
        {
            StartWebsite();
            loginPageObj.LoginSteps();
            homePageObj.ShareSkillButton();
            shareSkillPageObj.MarsShareSkillsForm();



        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
