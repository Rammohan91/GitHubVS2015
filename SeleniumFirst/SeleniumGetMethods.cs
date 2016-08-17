using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {

        public static string GetText(String Element, PropertyType Type)
        {
            if (Type == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(Element)).GetAttribute("value");
            if (Type == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(Element)).GetAttribute("value");
            else return string.Empty;
        }

        public static string GetTextFromDDL(String Element, PropertyType Type)
        {
            if (Type == PropertyType.Id)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(Element))).AllSelectedOptions.Single().Text;
            if (Type == PropertyType.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(Element))).AllSelectedOptions.Single().Text;
            else return string.Empty;
        }
    }
}
