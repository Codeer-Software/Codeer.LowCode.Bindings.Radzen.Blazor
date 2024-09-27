using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenDateTimeFieldSearchDriver : ComponentBase
    {
        public RadzenDateTimeDriver StartDate => ByCssSelector("[data-search-target='min'] > input").Wait().Find<RadzenDateTimeDriver>();
        public RadzenDateTimeDriver EndDate => ByCssSelector("[data-search-target='max'] > input").Wait().Find<RadzenDateTimeDriver>();
        public RadzenDateTimeFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenDateTimeFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenDateTimeFieldSearchDriver>();
    }
}
