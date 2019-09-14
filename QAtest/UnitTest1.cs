using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QAtest
{
    class UnitTest1
    {
        public IWebDriver driver;


        public void init()
        {
            driver = new FirefoxDriver();
        }
        public void NavigatetoGoogle()
        {
            driver.Navigate().GoToUrl("google.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
        }
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
