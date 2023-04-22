using Mars_Competition_Task.Driver;
using Mars_Competition_Task.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_Competition_Task.Pages;

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
            public void ShareSkillAddition()
            {         
                homePageObj.ShareSkillButton();
            }

            [TearDown]
            public void CloseTestRun()
            {
                driver.Quit();
            }
    }
}
