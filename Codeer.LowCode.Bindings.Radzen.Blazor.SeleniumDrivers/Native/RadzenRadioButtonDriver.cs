using Selenium.StandardControls;
using OpenQA.Selenium;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native
{
    public class RadzenRadioButtonDriver(IWebElement element) : ControlDriverBase(element)
    {
        public bool Checked => Element.FindElement(By.CssSelector(".rz-radiobutton-box"))
            .GetAttribute("class").Contains("rz-state-active");
    }
}
