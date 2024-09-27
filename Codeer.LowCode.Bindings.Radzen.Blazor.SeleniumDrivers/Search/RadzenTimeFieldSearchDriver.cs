using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenTimeFieldSearchDriver : ComponentBase
    {
        public RadzenTimeDriver StartTime => ByCssSelector("[data-search-target='min'] > input").Wait().Find<RadzenTimeDriver>();
        public RadzenTimeDriver  EndTime => ByCssSelector("[data-search-target='max'] > input").Wait().Find<RadzenTimeDriver>();
        public RadzenTimeFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenTimeFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenTimeFieldSearchDriver>();
    }
}
