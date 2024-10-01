using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native
{
    public class RadzenToggleButtonDriver(IWebElement element) : ControlDriverBase(element)
    {
        public bool Checked => Element.FindElement(By.TagName("input")).GetAttribute("aria-checked") == "true";

        public void Edit(bool b)
        {
            if (Checked == b) return;
            Element.Click();
        }
    }
}
