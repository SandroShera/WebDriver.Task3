using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace WebDriver.Task3
{
    public class CloudGoogleMainPageElementMap
    {
        private readonly WebDriverWait wait;

        public CloudGoogleMainPageElementMap(WebDriverWait wait)
        {
            this.wait = wait;
        }

        public IWebElement SearchIcon
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"kO001e\"]/div[2]/div[1]/div/div[2]/div[2]/div[1]")));
            }
        }

        public IWebElement SearchInput
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"i4\"]")));
            }
        }
    }
}
