using System;
using Gherkin;
using TechTalk.SpecFlow;

namespace ConsoleApp1.googleTest.steps
{
    [Binding]
    public class stepDefinition
    {
        [Given(@"I'm on the homepage")]
        public void GivenImOnTheHomepage()
        {
            Console.WriteLine("asd");
        }
         
        [When(@"I type 'The name of the wind' into the search field")]
        public void ITypeTheNameOfTheWindIntoTheSearchField()
        {
            Console.WriteLine("asd");            
        }
         
        [Then(@"I go to the search results page")]
        public void IGoToTheSearchResultsPage()
        {
            Console.ReadLine();
        }
        
        
    }
}