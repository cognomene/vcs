using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace NamuDarbai
{

    class WhatIsMyBrowser
    {

        [Test]
        public static void FirefoxTest()
        {
            IWebDriver firefoxDriver = new FirefoxDriver();
            firefoxDriver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            firefoxDriver.Manage().Window.Maximize();


            IWebElement browserAndOsDetection = firefoxDriver.FindElement(By.CssSelector(".simple-major"));
            Assert.AreEqual("Firefox 105 on macOS (Catalina)", browserAndOsDetection.Text, "Text is not the same");

            firefoxDriver.Quit();
        }



        [Test]
        public static void ChromeTest()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            chromeDriver.Manage().Window.Maximize();


            IWebElement browserAndOsDetection = chromeDriver.FindElement(By.CssSelector(".simple-major"));
            Assert.AreEqual("Chrome 106 on macOS (Catalina)", browserAndOsDetection.Text, "Text is not the same");

            chromeDriver.Quit();
        }



    }
}

