using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using ="TitleId")]
        public IWebElement ddlTitle { get; set; }

        [FindsBy(How = How.Name, Using ="Initial")]
        public IWebElement txtIntital { get; set; }

        [FindsBy(How = How.Name, Using ="FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }


        public void FillFormDetails(String Initial, String FirstName, String MiddleName)
        {

            SeleniumSetMethods.EnterText(txtIntital, "B.");
            SeleniumSetMethods.EnterText(txtFirstName, "Rammohan");
            SeleniumSetMethods.EnterText(txtMiddleName, "Manikyala Rao");

            Console.WriteLine("First Name is :" + SeleniumGetMethods.GetText(txtFirstName));
            Console.WriteLine("Initial is :" + SeleniumGetMethods.GetText(txtIntital));
            Console.WriteLine("Middle Name is :" + SeleniumGetMethods.GetText(txtMiddleName));

            SeleniumSetMethods.Click(btnSave);
            
            /*
            txtIntital.SendKeys(Initial);
            txtFirstName.SendKeys(FirstName);
            txtMiddleName.SendKeys(MiddleName);
            btnSave.Click();
        */
        }
        
    }
}
