using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    enum PropertyType
    {
        Id,
        Name,
        LinkTest,
        CssName,
        ClassName
    }

    enum Drivers
    {
        Chrome,
        Firefox,
        IE
    }

    class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }

        
        public static IWebDriver SelectDriver(Drivers SelectedDriver)
        {
            if (SelectedDriver == Drivers.Chrome)
                return driver = new ChromeDriver();
            else if (SelectedDriver == Drivers.Firefox)
                return driver = new FirefoxDriver();
            else if (SelectedDriver == Drivers.IE)
                return driver = new InternetExplorerDriver(@"D:\SeleniumTutorials\SeleniumFirst\packages");
            return driver;

        }
    }
}
