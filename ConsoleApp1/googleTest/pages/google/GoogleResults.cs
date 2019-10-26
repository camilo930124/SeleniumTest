using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ConsoleApp1.googleTest.pages.google
{
    public class GoogleResults
    {
        [FindsBy(How = How.XPath, Using = "//div[@id='search']//h3[1]")]
        private IWebElement lnkFirstResult;
        
    }
}