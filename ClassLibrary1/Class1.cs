using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassLibrary
{
    [TestFixture]
    public class Class1
    {
        IWebDriver webdriver = new ChromeDriver();

        [TestCase]
        public void MainTest1()
        {
            webdriver.Url = "https://www.booksite.ru/";
            Assert.Equals("ВОЛОГОДСКАЯ ОБЛАСТНАЯ УНИВЕРСАЛЬНАЯ НАУЧНАЯ БИБЛИОТЕКА", webdriver.Title);
            webdriver.Close();
        }
        [TestCase]
        public void MainTest2()
        {
            webdriver.Url = "https://www.booksite.ru/";
            IWebElement element = webdriver.FindElement(By.XPath("//*[@id=logo]/a/img"));
            element.Click();
            bool status = element.Selected;
        }
        [TestCase]
        public void MainTest3()
        {
            webdriver.Url = "https://www.booksite.ru/";
            IWebElement search = webdriver.FindElement(By.XPath("//*[@id=\"s\"]"));
            search.Click();
            search.SendKeys("бла бла");
        }
        [TestCase]
        public void MainTest4()
        {
            webdriver.Url = "https://www.booksite.ru/";
            IWebElement element = webdriver.FindElement(By.XPath("//*[@id=\"slider_container\"]/div/div[1]/div[1]/div/ul[1]/li[2]/a/img"));
            bool status = element.Displayed;
        }
        [TestCase]
        public void MainTest5()
        {
            webdriver.Url = "https://www.booksite.ru/";
            IWebElement element = webdriver.FindElement(By.XPath("//*[@id=\"menu-item-203\"]/a"));

        }
        [TearDown]
        public void testEnd()
        {
            webdriver.Quit();
        }
    }
}
