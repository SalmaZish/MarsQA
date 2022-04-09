using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using MarsQAProject.Utilities;
using MarsQAProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MarsQAProject
{
    [Binding]
    public class PDFeatureStepDefinitions : CommonDriver
    {
        //Initializing page objects

        MarsLoginPage LoginObj = new MarsLoginPage();
        MProfilelanguagePage mProfilelanguagePageObj = new MProfilelanguagePage();
        MProfileSkillPage MProfileSkillPage = new MProfileSkillPage();
        IWebDriver mydriver = new ChromeDriver();

        [Given(@"I login in the Blockchain-based skill exchange platform portal successfully")]
        public void GivenILoginInTheBlockchain_BasedSkillExchangePlatformPortalSuccessfully()
        {
          
            // Call login Page
         
            LoginObj.LoginPage(mydriver);

        }

        [Given(@"I navigate to profile page")]
        public void GivenINavigateToProfilePage()
        {
            //throw new PendingStepException();
        }

        [When(@"I add my language details")]
        public void WhenIAddMyLanguageDetails()
        {
            // Call Mprofile language page

            mProfilelanguagePageObj.AddLanguge(mydriver);
        }


        [Then(@"the language details added successfully")]
        public void ThenTheLanguageDetailsAddedSuccessfully()
        {
            string language = mProfilelanguagePageObj.GetLanguage(mydriver);
            string level = mProfilelanguagePageObj.GetLevel(mydriver);

            Assert.That(language == "English", "Actual language text and expected language do not match");
            Assert.That(level == "Basic", " Actual level text and expected level do not match"); 

        }

        [When(@"I add my skill details")]
        public void WhenIAddMySkillDetails()
        {
            MProfileSkillPage.AddNewSkill(mydriver);
        }

        [Then(@"the skill details added successfully")]
        public void ThenTheSkillDetailsAddedSuccessfully()
        {
            string skill = MProfileSkillPage.GetSkill(mydriver);
            string level = MProfileSkillPage.GetLevel(mydriver);

            Assert.That(skill == "Programming", "Actual skilldetail and expected skilldetail do not match");
            Assert.That(level == "Beginner", " Actual level details and expected level deatails do not match");
        }

        [When(@"I add my certification details")]
        public void WhenIAddMyCertificationDetails()
        {
            throw new PendingStepException();
        }

        [Then(@"the certification details added successfully")]
        public void ThenTheCertificationDetailsAddedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I edit '([^']*)','([^']*)' on an existing languages tab")]
        public void WhenIEditOnAnExistingLanguagesTab(string p0, string p1)
        {
            mProfilelanguagePageObj.EditLanguge(mydriver,p0,p1);
        }

        [Then(@"the profile details should have the updated '([^']*)','([^']*)'")]
        public void ThenTheProfileDetailsShouldHaveTheUpdated(string english, string fluent)
        {
            //throw new PendingStepException();
        }

        [When(@"I edit '([^']*)','([^']*)' on an existing skills tab")]
        public void WhenIEditOnAnExistingSkillsTab(string driving, string expert)
        {
            throw new PendingStepException();
        }

        [Then(@"the skills tab should have the updated '([^']*)','([^']*)'")]
        public void ThenTheSkillsTabShouldHaveTheUpdated(string driving, string expert)
        {
            throw new PendingStepException();
        }

        [When(@"I edit '([^']*)','([^']*)','([^']*)' on an existing certification tab")]
        public void WhenIEditOnAnExistingCertificationTab(string diploma, string asmi, string p2)
        {
            throw new PendingStepException();
        }

        [Then(@"the certification tab should have the updated '([^']*)','([^']*)','([^']*)'")]
        public void ThenTheCertificationTabShouldHaveTheUpdated(string diploma, string asmi, string p2)
        {
            throw new PendingStepException();
        }

        [When(@"I delete'([^']*)','([^']*)' on an existing languages tab")]
        public void WhenIDeleteOnAnExistingLanguagesTab(string language, string level)
        {
            mProfilelanguagePageObj.DeleteLanguge(mydriver);
        }

        [Then(@"the languages tab should delete '([^']*)','([^']*)'")]
        public void ThenTheLanguagesTabShouldDelete(string p0, string level)
        {
            throw new PendingStepException();
        }


        
    }
}
