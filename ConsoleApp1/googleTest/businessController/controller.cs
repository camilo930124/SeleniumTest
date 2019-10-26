using ConsoleApp1.googleTest.pages.google;
using ConsoleApp1.googleTest.webController;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.googleTest.businessController
{
    class controller
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");

            WebActions.launchWebApp("Chrome", "http://www.google.com");

            /*WebActions.Driver.FindElement(By.Name("q")).SendKeys("The name of the wind");
            Thread.Sleep(8000);
            WebActions.Driver.FindElement(By.XPath("//img[@alt='Google']")).Click();
            WebActions.Driver.FindElement(By.XPath("//div[@class='FPdoLc VlcLAe']//input[@name='btnK']")).Click();    
            Console.Read();*/

            GoogleHome googleHome = new GoogleHome();
            PageFactory.InitElements(WebActions.Driver, googleHome);
            googleHome.search("The name of the wind");

            //PageFactory.InitElements(webActions.Driver, googleHome);
            Console.Read();
            WebActions.closeWebApp();

            //GoogleHome googleHome = PageFactory.initElements
        }
    }
}
