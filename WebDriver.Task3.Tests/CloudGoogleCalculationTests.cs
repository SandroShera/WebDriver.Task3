using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriver.Task3.Tests
{
    internal class CloudGoogleCalculationTests
    {
        private IWebDriver browser;
        private WebDriverWait wait;
        private CloudGoogleMainPage mainPage;
        private const string searchText = "Google Cloud Platform Pricing Calculator";

        [SetUp]
        public void SetUp()
        {
            browser = new ChromeDriver();
            browser.Manage().Window.Maximize();
            wait = new(browser, TimeSpan.FromSeconds(10));
            mainPage = new(browser, wait);
        }

        [Test]
        public void PriceIsCalculated()
        {
            mainPage.Navigate();
            mainPage.ClickSearchIcon();
            mainPage.Search(searchText);

            SearchResultPage searchResultPage = new(browser, wait);
            searchResultPage.ClickPricingCalculatorResult();

            CloudGoogleCalculatorPage calculatorPage = new(browser, wait);
            calculatorPage.ClickAddEstimateButton();
            calculatorPage.ClickComputeEngineButton();
            calculatorPage.EnterNumberOfInstances(4);
            calculatorPage.ExpandMachineTypeDropDown();
            calculatorPage.SelectN1Standart8Core();
            calculatorPage.AddGpus();
            calculatorPage.ExpandGpuTypeDropdown();
            calculatorPage.SelectTeslaV100Gpu();
            calculatorPage.ExpandLocalSsdDropdown();
            calculatorPage.SelectLocalSsd2x375();
            calculatorPage.SelectCommitedUsagee1Year();

            bool actual = calculatorPage.IsPriceCalculated();

            Assert.IsTrue(actual);
        }

        [TearDown] 
        public void TearDown() 
        {
            browser.Quit();
        }
    }
}
