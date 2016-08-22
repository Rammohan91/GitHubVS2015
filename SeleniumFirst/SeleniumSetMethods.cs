using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
    
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Button, CheckBox, Option
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }
      
        public static void SelectDropDown(this IWebElement element,string value)
        {        
            new SelectElement(element).SelectByText(value);       
        }

    }
}
