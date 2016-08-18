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

        public static string GetText(IWebElement Element)
        {
            return Element.GetAttribute("value");
        }

        public static string GetTextFromDDL(IWebElement Element, PropertyType Type)
        {
                return new SelectElement(Element).AllSelectedOptions.Single().Text;
        }
    }
}
