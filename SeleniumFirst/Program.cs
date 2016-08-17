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
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=username&Password=password&Login=Login");

        }

        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Name);
            SeleniumSetMethods.EnterText("Initial", "B", PropertyType.Name);
            SeleniumSetMethods.EnterText("FirstName", "Rammohan", PropertyType.Name);

            Console.WriteLine( "Dropdown Values are: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Name) );
            Console.WriteLine( "Initial is : " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
            Console.WriteLine("First Name is : " + SeleniumGetMethods.GetText("FirstName", PropertyType.Name));
   
            SeleniumSetMethods.Click("Save", PropertyType.Name);
            //Test
        }

      
        [TearDown]
        public void Close()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the Browser");
        }
    }
}
