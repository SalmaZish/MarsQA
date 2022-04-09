using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using MarsQAProject.Utilities;


namespace MarsQAProject.Pages
{
    internal class MProfileSkillPage
    {

        public void AddNewSkill(IWebDriver driver)
        {
            try
            { 
               //Click Skills tab
                Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 2);
                IWebElement SkillsTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
                SkillsTab.Click();

                //Click add new button
               // Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
                IWebElement AddnewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
                AddnewButton.Click();

                // Enter skill data
                IWebElement SkillData = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
                SkillData.SendKeys("Programming");

                // Choose skill level
                //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select
                IWebElement Skilllevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
                Skilllevel.Click();

                // Select Beginnerlevel
                IWebElement Beginnerlevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
                Beginnerlevel.Click();

                // Click add button
                IWebElement AddButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
                AddButton.Click();

           }
            catch (Exception ex)
            {
                Assert.Fail("Error in AddNewSkill", ex.Message);
            }

}

        // Getting Skill string
        public string GetSkill(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]", 5);
            IWebElement SkillDetails = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return SkillDetails.Text;

        }

        // Getting level string
        public string GetLevel(IWebDriver driver)
        {
            IWebElement LevelDetails = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return LevelDetails.Text;

        }

        public void EditSkill(IWebDriver driver, string skill, string level)
        {
            try
            {

                    //Click Skills tab
                    Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 2);
                IWebElement SkillsTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
                SkillsTab.Click();
                //Click Edit button
                //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]              
                Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]", 10);

                IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
                EditButton.Click();

                //Edit Level
                IWebElement skilltext = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
                skilltext.Clear();
                skilltext.SendKeys(skill);

                //check if level example data is NOT empty or not null
                if ((level != "") && (level != null))
                {
                    // change level drop down
                    IWebElement skilllevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
                    skilllevel.Click();

                    if (level == "Expert")
                    {
                        Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]", 2);
                        IWebElement levels = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
                        levels.Click();
                    }
                }

                // Click the update button

                IWebElement Updatebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
                Updatebutton.Click();

          }
            catch (Exception ex)
            {
                Assert.Fail("Error in EditSkill", ex.Message);
            }



}






    }
}
