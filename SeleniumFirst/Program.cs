using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        // Create Reference for Broser
        

        static void Main(string[] args)
        {

            
        }

        [SetUp]
        public void Inititalize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            //Navigate to Google Page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            PropertiesCollection.driver.Manage().Window.Maximize();

        }

        [Test]
        public void ExecuteTest()
        {

            LoginPageObject LoginPage = new LoginPageObject();
            LoginPage.Login("username", "password");
            



            EAPageObject Page = new EAPageObject();
            Page.FillFormDetails("B.", "Rammohan", "Manikyala Rao");

            
            //Page.txtIntital.SendKeys("Execute Automation");
            Page.btnSave.Click();


            /*
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Name);
            SeleniumSetMethods.EnterText("Initial", "B", PropertyType.Name);
            SeleniumSetMethods.EnterText("FirstName", "Rammohan", PropertyType.Name);

            Console.WriteLine( "Dropdown Values are: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Name) );
            Console.WriteLine( "Initial is : " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
            Console.WriteLine("First Name is : " + SeleniumGetMethods.GetText("FirstName", PropertyType.Name));
   
            SeleniumSetMethods.Click("Save", PropertyType.Name);
            //Test
            */
        }

      
        [TearDown]
        public void Close()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the Browser");
        }
    }
}
