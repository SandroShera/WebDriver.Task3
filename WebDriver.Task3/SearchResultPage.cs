using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace WebDriver.Task3
{
    public class SearchResultPage
    {
        private readonly IWebDriver browser;
        private readonly WebDriverWait wait;

        public SearchResultPage(IWebDriver browser, WebDriverWait wait)
        {
            this.browser = browser;
            this.wait = wait;
        }

        public SearchResultPageElementMap Map
        {
            get
            {
                return new(wait);
            }
        }

        public void ClickPricingCalculatorResult()
        {
            Map.PricingCalculatorResult.Click();
        }

    }
}
