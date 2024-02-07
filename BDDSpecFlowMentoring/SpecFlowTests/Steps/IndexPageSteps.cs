using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;
using SpecFlowTests.Pages;

namespace SpecFlowTests.Steps
{
    [Binding]
    public class IndexPageSteps
    {
        private IWebDriver driver;
        private IndexPage indexPage;

        public IndexPageSteps()
        {
            driver = new ChromeDriver();
            indexPage = new IndexPage(driver);
        }

        [Given(@"I navigate to EPAM website")]
        public void GivenINavigateToEPAMWebsite()
        {
            indexPage.Open();
        }

        [When(@"I click on the Search icon element")]
        public void WhenIClickOnTheSearchIconElement()
        {
            indexPage.ClickSearchIcon();
        }

        [When(@"I enter the text '(Automation)' into the search input")]
        public void WhenIEnterTheTextIntoTheSearchInput(string searchText)
        {
            indexPage.EnterSearchText(searchText);
        }

        [When(@"I click on the Find button")]
        public void WhenIClickOnTheFindButton()
        {
            indexPage.ClickFindButton();
        }

        [Then(@"The list of search results is displayed on the page")]
        public void ThenTheListOfSearchResultsIsDisplayedOnThePage()
        {
            bool isDisplayed = indexPage.VerifySearchResultsAreDisplayed();
            Assert.IsTrue(isDisplayed);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
