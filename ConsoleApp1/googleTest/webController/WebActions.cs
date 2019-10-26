using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace ConsoleApp1.googleTest.webController
{
    public static class WebActions
    {
        private static IWebDriver driver;
        public static IWebDriver Driver{
            get{return driver;}
            set{driver = value;}
        }
        public static void launchWebApp(String browser, String url)
        {
            switch (browser)
            {
                case "Firefox":
                    driver=new FirefoxDriver();
                    break;
                case "Chrome":
                    driver=new ChromeDriver();
                    break;
                default:
                    driver=new ChromeDriver();
                    break;
            }

            //driver.Manage().Timeouts().ImplicitWait(30);
            driver.Url = url;
        }
        
        public static void closeWebApp()
        {
            driver.Close();
            driver.Quit();
        }
        
        public static void clickElement(IWebElement element, Boolean takeScreenshot){
            element.Click();
        }
        
        public static void sendTextToElement(IWebElement element, String text, Boolean takeScreenshot){
            element.SendKeys(text);
        }

        public static string getTextFromElement(IWebElement element, Boolean takeScreenshot)
        {
            return element.GetAttribute("Text");
        }

        public static void waitVisible(String elementXpath, int timeout, Boolean takeScreenshot)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(elementXpath)));
        }
    }
}