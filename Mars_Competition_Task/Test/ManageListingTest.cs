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
    public class ManageListingTest: MarsDriver
    {

        //Page Object Initialization and Definition
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        ManageListingPage manageListingPageObj= new ManageListingPage();

       

            [Test, Order(1)]
            public void ShareSkillEdit()
            {
            
            homePageObj.ManageListingTbButton();
            manageListingPageObj.UpdateShareSkill();
            manageListingPageObj.UpdateTitle();
            manageListingPageObj.UpdateDescription();
            manageListingPageObj.UpdateCategory();
            manageListingPageObj.UpdateSubCategory();
            manageListingPageObj.UpdateTags();
            manageListingPageObj.UpdateServiceTypeRB();
            manageListingPageObj.UpdateLocationTypeRB();
            manageListingPageObj.UpdateSExchTypeRB();
            manageListingPageObj.UpdateWorkSamples();
            manageListingPageObj.SaveButton();
            }

            [TearDown]
            public void CloseTestRun()
            {
                driver.Quit();
            }
    }
}
