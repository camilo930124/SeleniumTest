using ConsoleApp1.googleTest.webController;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ConsoleApp1.googleTest.pages.google
{
    public class GoogleHome
    {

        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement inputSearch;
        
        [FindsBy(How = How.XPath, Using = "//div[@class='FPdoLc VlcLAe']//input[@name='btnK']")]
        private IWebElement btnGoogleSearch; 
        
        [FindsBy(How = How.XPath, Using = "//div[@class='FPdoLc VlcLAe']//input[@name='btnI']")]
        private IWebElement btnImFeelingLucky;
        
        [FindsBy(How = How.XPath, Using = "//img[@alt='Google']")]
        private IWebElement imgGoogle;        
        
        [FindsBy(How = How.XPath, Using = "//ul[@role='listbox']")]
        private IWebElement ulResults;

        public void search(string textToSearch)
        {
            WebActions.sendTextToElement(inputSearch,textToSearch,true);
            WebActions.waitVisible("//ul[@role='listbox']",30,true);
            WebActions.clickElement(imgGoogle,false);
            WebActions.clickElement(btnGoogleSearch,true);
        }
        
    }
}