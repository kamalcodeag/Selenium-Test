using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Test.MyTest();
        }
        
    }

    public class Test
    {
        public static void MyTest()
        {
            #region WhatsApp
            IWebDriver driver = new ChromeDriver();

            Uri uri = new Uri("https://web.whatsapp.com/");
            driver.Navigate().GoToUrl(uri);
            driver.Manage().Window.Maximize();
            Thread.Sleep(6000);
            string text = "text";

            IWebElement rovers = driver.FindElement(By.CssSelector("span[title='Aspçilər']"));
            rovers.Click(); //OK
            Thread.Sleep(3000);

            for (int i = 1; i <= 100; i++)
            {
                //string result = text + " => " + i;
                IWebElement input = driver.FindElement(By.CssSelector("div[spellcheck='true']"));
                input.SendKeys(text); //OK

                IWebElement send = driver.FindElement(By.CssSelector("span[data-icon='send']"));
                send.Click();
            }

            //ICollection<IWebElement> errors = driver.FindElements(By.CssSelector("span[data-icon='send']"));
            //foreach (var error in errors)
            //{
            //    error.Click(); //OK
            //}

            Thread.Sleep(3000);

            driver.Close();
            driver.Quit();
            #endregion
        }
    }
}
