using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenDateFieldSearchDriver : ComponentBase
    {
        public RadzenDateDriver StartDate => ByCssSelector("[data-search-target='min'] > input").Wait().Find<RadzenDateDriver>();
        public RadzenDateDriver EndDate => ByCssSelector("[data-search-target='max'] > input").Wait().Find<RadzenDateDriver>();
        public RadzenDateFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenDateFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenDateFieldSearchDriver>();
    }
}
