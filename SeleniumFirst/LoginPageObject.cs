using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public void Login(String UserName, String Password)
        {
            txtUserName.SendKeys(UserName);
            txtPassword.SendKeys(Password);

            Console.WriteLine("UserName is :" + SeleniumGetMethods.GetText(txtUserName));
            Console.WriteLine("Password is :" + SeleniumGetMethods.GetText(txtPassword));

            btnLogin.Submit();
            //return new EAPageObject();
        }

    }
}
