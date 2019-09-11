using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QAtest
{
    class FirstTestClass
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new ChromeDriver();

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            System.Threading.Thread.Sleep(4000);
            driver.Manage().Window.Maximize();
            #region Found by Xpath
            try
            {
                driver.FindElement(By.XPath("//input"));
                Console.WriteLine("Element found by XPath");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
            #endregion
            #region All link
            /* foreach (var item in driver.FindElements(By.TagName("a")));
             {
                 Console.WriteLine(item.GetAttribute("href"));
             }*/
            #endregion
            #region Simple find Element
            //IWebElement element = driver.FindElement(By.Name("search_query"));
            //element.SendKeys("Pritom Chaki");        
            //IWebElement element1 = driver.FindElement(By.Id("search-icon-legacy"));
            // element1.Click();
            #endregion
            #region Page itle Mtching
            /*   
             string ActualResult;
             string ExpectedResult = "YouTube"
            
              ActualResult = driver.Title;
              if(ActualResult.Contains(ExpectedResult))
              {
                  Console.WriteLine("Test Case Passed");
                  Console.Read();
              }
              else
              {
                  Console.WriteLine("Test Case Failed");
                  Console.Read();
              }*/
            #endregion
            #region List Object
           /* IWebElement ActionContainer = driver.FindElement(By.Id("global-actions"));
            ReadOnlyCollection<IWebElement> GlobalActions = ActionContainer.FindElements(By.TagName("li"));
            foreach (IWebElement GlobalAction in GlobalActions)
            {
                string ActionName = GlobalActions.Text;
                GlobalAction.Click();
                Thread.Sleep(5000);
            }*/
            #endregion

            driver.Close();
           driver.Quit();
        }
    }
}
