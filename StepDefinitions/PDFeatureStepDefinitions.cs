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
        MProfileCertPage MProfileCertPageObj = new MProfileCertPage();
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
            MProfileCertPageObj.AddNewCert(mydriver);

        }

        [Then(@"the certification details added successfully")]
        public void ThenTheCertificationDetailsAddedSuccessfully()
        {
            string Cert = MProfileCertPageObj.GetCert(mydriver);
            string From = MProfileCertPageObj.GetCertFrom(mydriver);
            string Year = MProfileCertPageObj.GetCertYear(mydriver);

            Assert.That(Cert == "Diploma", "Actual Certificate and expected Certificate do not match");
            Assert.That(From == "QUT", " Actual Cerificate From and expected Cerificate From  do not match");
            Assert.That(Year== "2020", " Actual Cerificate Year and expected Cerificate Year  do not match");
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
        public void WhenIEditOnAnExistingSkillsTab(string p1, string p2)
        {
            MProfileSkillPage.EditSkill(mydriver, p1, p2);
        }

        [Then(@"the skills tab should have the updated '([^']*)','([^']*)'")]
        public void ThenTheSkillsTabShouldHaveTheUpdated(string driving, string expert)
        {
            throw new PendingStepException();
        }

        [When(@"I edit '([^']*)','([^']*)','([^']*)' on an existing certification tab")]
        public void WhenIEditOnAnExistingCertificationTab(string p0, string p1, string p2)
        {
            MProfileCertPageObj.EditCert(mydriver, p0, p1, p2);
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
