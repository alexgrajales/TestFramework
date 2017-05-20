using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver(@"C:\Users\agrajales\Downloads\chromedriver_win32 (2)");
            driver.Navigate().GoToUrl("https://www.google.com.co");
            var query = driver.FindElement(By.Name("q"));
            query.SendKeys("hello selenium");
            query.Submit();

            var dirverFirefox = new FirefoxDriver();
            dirverFirefox.Url = "https://www.google.com.co";

            //var imagenesLink = driver.FindElementsByCssSelector("#hdtb .hdtb-mitem a")[1];
            //var imagenesLink = driver.FindElements(By.CssSelector("#hdtb .hdtb-mitem a"))[1];
            //imagenesLink.Click();
            //var ul = driver.FindElements(By.ClassName("rg_ul"));
            //var firstImageLink = ul.FindElements(By.TagName("a"))[0];
        }
    }
}
