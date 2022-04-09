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
    internal class MProfileCertPage
    {
        public void AddNewCert(IWebDriver driver)
        {
            try
            {
                //Click Certs tab
                Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 2);
                IWebElement CertsTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
                CertsTab.Click();

                //Click add new button
                // Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
                IWebElement AddnewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
                AddnewButton.Click();

                // Enter Cert data
                IWebElement CertData = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
                CertData.SendKeys("Diploma");

                //Enter Cert From
                IWebElement CertFrom = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
                CertFrom.SendKeys("QUT");


                // Choose CertYear

                IWebElement CertYear = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
                CertYear.Click();

                // Select Year
                IWebElement Year = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[4]"));
                Year.Click();

                // Click add button
                IWebElement AddButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
                AddButton.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("Error in AddNewCert", ex.Message);
            }


        }

        // Getting Cert string
        public string GetCert(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]", 5);
            IWebElement CertDetails = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return CertDetails.Text;

        }

        // Getting CertFrom
        public string GetCertFrom(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]", 5);
            IWebElement CertDetails = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return CertDetails.Text;

        }

        // Getting Cert Year
        public string GetCertYear(IWebDriver driver)
        {
            IWebElement YearText = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return YearText.Text;

        }

        public void EditCert(IWebDriver driver, string Cert, string CertFrom, string CertYear )
        {

            try
            {

                    //Click Certs tab
                Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 2);
                IWebElement CertsTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
                CertsTab.Click();


                //Click Edit button
                        
                Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]", 10);

                IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]"));
                EditButton.Click();

                //Edit Cert
                IWebElement Certtext = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
                Certtext.Clear();
                Certtext.SendKeys(Cert);

           

                // Click the update button

                IWebElement Updatebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
                Updatebutton.Click();

            }
            catch (Exception ex)
            {
                Assert.Fail("Error in EditCert", ex.Message);
            }



        }


    }
}
