using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Mit_Selenium_Netcore.Pages
{
    class LoginPage : DriverHelper
    {

        IWebElement textUserName => Driver.FindElement(By.Name("UserName"));
        IWebElement textPassword => Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Driver.FindElement(By.Name("Login"));


        public void EnterUserNameAndPassword(string userName, string password)
        {
            textUserName.SendKeys(userName);
            textPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }



    }
    
    
}
