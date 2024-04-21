using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace WebDriver.Task3
{
    public class CloudGoogleCalculatorPage
    {
        private readonly IWebDriver browser;
        private readonly WebDriverWait wait;
        private readonly Actions actions;

        public CloudGoogleCalculatorPage(IWebDriver browser, WebDriverWait wait)
        {
            this.browser = browser;
            this.wait = wait;
            actions = new(this.browser);
        }

        public CloudGoogleCalculatorPageElementMap Map
        {
            get
            {
                return new(wait);
            }
        }

        public void ClickAddEstimateButton()
        {
            Map.AddEstimateButton.Click();
        }

        public void ClickComputeEngineButton()
        {
            Map.ComputeEngineButton.Click();
        }

        public void EnterNumberOfInstances(int numberOfInstances)
        {
            Map.NumberOfInstancesInput.Clear();
            Map.NumberOfInstancesInput.SendKeys(numberOfInstances.ToString());
        }

        public void ExpandMachineTypeDropDown()
        {
            actions.MoveToElement(Map.MachineTypeDropdownExpandButton);
            actions.Perform();
            Map.MachineTypeDropdownExpandButton.Click();
        }

        public void SelectN1Standart8Core()
        {
            Map.N1Standart8Core.Click();
        }

        public void AddGpus()
        {
            actions.MoveToElement(Map.AddGpusSwitch);
            actions.Perform();
            Map.AddGpusSwitch.Click();
        }

        public void ExpandGpuTypeDropdown()
        {
            actions.MoveToElement(Map.GpuModelDropdown);
            actions.Perform();
            Map.GpuModelDropdown.Click();
        }

        public void SelectTeslaV100Gpu()
        {
            Map.TeslaV100.Click();
        }

        public void ExpandLocalSsdDropdown()
        {
            actions.MoveToElement(Map.LocalSsdDropdown);
            actions.Perform();
            Map.LocalSsdDropdown.Click();
        }

        public void SelectLocalSsd2x375()
        {
            Map.Ssd2x375.Click(); 
        }

        public void SelectCommitedUsagee1Year()
        {
            actions.MoveToElement(Map.CommitedUsage1Year);
            actions.Perform();
            Map.CommitedUsage1Year.Click();
        }

        public bool IsPriceCalculated()
        {
            try
            {
               return  Map.CalculatedPrice.Displayed;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
