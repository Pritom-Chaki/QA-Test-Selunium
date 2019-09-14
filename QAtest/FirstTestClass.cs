using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace QAtest
{
    class FirstTestClass
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new ChromeDriver();

            IWebDriver driver = new FirefoxDriver();
            //var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            #region Found by Xpath
            //try
            //{
            //    driver.FindElement(By.XPath("//input"));
            //    Console.WriteLine("Element found by XPath");
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
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
            //element.Sendkeys(OpenQA.Selenium.Keys.Control + "t"); //Open New Tab
            //var time1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond; // Knowing Time
            // driver.Navigate().Refresh(); //Refresh Page
            //System.Drawing.Size windowsize = new System.Drawing.Size(480, 320); //Resize Browser Window
            //driver.Manage().Window.Size = windowsize;
           // Console.WriteLine(element.Displayed);  //Check the element
            #endregion
            #region Dropdown Value
            //var option = driver.FindElement(By.Id("myList"));
            //var selectElement = new SelectElement(option);
            //Thread.Sleep(5000);
            //selectElement.SelectByText("three");
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
            #region Java Script
            //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //string title = (string)js.ExecuteScript("return document.title");
            //Console.WriteLine(title);
            //js.ExecuteScript("window.scrollBy(0,950);"); //Scrool the window
            //Console.Read();
            #endregion
            #region Accept Alert
            //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //js.ExecuteScript("alert('Hi this is alert');");
            //Thread.Sleep(5000);
            //IAlert alert = driver.SwitchTo().Alert();
            //alert.Accept();
            //Console.Read();
            #endregion
            #region Co Ordinate Location
            //IWebElement element = driver.FindElement(By.Id("mp-tfa-h2"));
            //Thread.Sleep(3000);
            //int x = element.Location.X;
            //int y = element.Location.Y;
            //Console.WriteLine("X location: " + x);
            //Console.WriteLine("Y location: " + y);
            //Console.Read();
            #endregion
            //driver.Close();
            //   driver.Quit();
        }
    }
}
