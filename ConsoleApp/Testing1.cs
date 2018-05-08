using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeleniumTesting0805
{
    class CreatingOrganization
    {
        private IWebDriver Chrome;

        [SetUp]
        public void SetUp()
        {
            Chrome = new ChromeDriver();
            Chrome.Manage().Window.Maximize();
            Chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [Test]
        public void Test()
        {
            try
            {
                Chrome.Navigate().GoToUrl("https://examdevtst1.pearsonvue.com/ExamDeveloper/login/Login.aspx");
                Chrome.FindElement(By.XPath("//*[@id='ctl00_RHSContentPlaceHolder_tbUsername']")).Clear();
                Chrome.FindElement(By.XPath("//*[@id='ctl00_RHSContentPlaceHolder_tbUsername']")).SendKeys("sbadmin");
                Chrome.FindElement(By.XPath("//*[@id='ctl00_RHSContentPlaceHolder_tbPassword']")).Clear();
                Chrome.FindElement(By.XPath("//*[@id='ctl00_RHSContentPlaceHolder_tbPassword']")).SendKeys("ed1tHPi0f");
            }
            catch (Exception error)
            {
                Console.Write("Ha ocurrido un error: " + error.Message);
            }
        }

        [TearDown]
        public void CloseBrowser()
        {
            Chrome.Quit();
        }
    }
}
