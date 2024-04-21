using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebDriver.Task3
{
    public class CloudGoogleMainPage
    {
        private readonly IWebDriver browser;
        private readonly WebDriverWait wait;
        private readonly string url = "https://cloud.google.com/";

        public CloudGoogleMainPage(IWebDriver browser, WebDriverWait wait)
        {
            this.browser = browser;
            this.wait = wait;
        }

        protected CloudGoogleMainPageElementMap Map
        {
            get
            {
                return new CloudGoogleMainPageElementMap(wait);
            }
        }

        public void Navigate()
        {
            this.browser.Navigate().GoToUrl(url);
        }

        public void ClickSearchIcon()
        {
            Map.SearchIcon.Click();
        }

        public void Search(string text)
        {
            Map.SearchInput.SendKeys(text + Keys.Enter);
        }
    }
}
