


using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Test_Mit_Selenium_Netcore;
using Test_Mit_Selenium_Netcore.Pages;

namespace Selenium_NetCore_Csharp
{
    public class Tests : DriverHelper
    {

        public  IWebDriver Driver;

        [SetUp]
        public void Setup()
        {

            Console.WriteLine("Setup");



            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {

            Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/ ");

            CustomControl.EnterText(Driver.FindElement(By.Id("Meal")), "Mango");
            CustomControl.Click(Driver.FindElement(By.XPath("//input[@name='ChildMeal1']/following-sibling::div[text()='Celery']")));
            CustomControl.SelectByText(Driver.FindElement(By.Id("Meal")), "cauliflower");
           // CustomControl control = new CustomControl();
            CustomControl.combobox("AllMealsCombo-awed", "Almond");

            
            Console.WriteLine("Test1");

            Assert.Pass();
        }
        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("https://www.opencart.com/ ");

            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickLogin();
            loginPage.EnterUserNameAndPassword("bkabiah@yahoo.fr", "qweasdyxc");
            loginPage.ClickLogin();
        }

    }


}