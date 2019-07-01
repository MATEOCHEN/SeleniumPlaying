using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumPlaying
{
    internal class Program
    {
        private static readonly IWebDriver WebDriver = new ChromeDriver(@"C:\Users\steze\source\repos\SeleniumPlaying\SeleniumPlaying");
        private static readonly string BaseUrl = "https://www.youtube.com";

        private static void Main(string[] args)
        {
            WebDriver.Navigate().GoToUrl(BaseUrl);
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            var searchInput = WebDriver.FindElement(By.Id("search"));
            searchInput.SendKeys("Selenium Playing is Fun");
        }
    }
}