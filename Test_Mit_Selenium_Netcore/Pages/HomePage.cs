using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Mit_Selenium_Netcore.Pages
{
    class HomePage : DriverHelper
    {

        
        IWebElement linkLogin => Driver.FindElement(By.LinkText("Login"));

        public void ClickLogin() => linkLogin.Click();
    }
}
