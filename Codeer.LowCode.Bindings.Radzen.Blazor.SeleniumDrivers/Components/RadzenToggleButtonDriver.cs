using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenToggleButtonDriver : ComponentBase
    {
        public bool IsChecked => ByTagName("input").Wait().Find().GetAttribute("aria-checked") == "true";
        
        public RadzenToggleButtonDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenToggleButtonDriver(ElementFinder finder) => finder.Find<RadzenToggleButtonDriver>();
    }
}
