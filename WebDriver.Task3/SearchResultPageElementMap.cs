using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace WebDriver.Task3
{
    public class SearchResultPageElementMap
    {
        private readonly WebDriverWait wait;

        public SearchResultPageElementMap(WebDriverWait wait)
        {
            this.wait = wait;
        }

        public IWebElement PricingCalculatorResult
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@track-name=\"google cloud pricing calculator\"  and @track-metadata-eventdetail=\"cloud.google.com/products/calculator\"]")));
            }
        }
    }
}
