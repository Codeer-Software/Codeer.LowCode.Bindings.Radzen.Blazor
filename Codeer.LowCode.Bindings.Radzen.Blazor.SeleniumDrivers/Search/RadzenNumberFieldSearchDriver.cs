using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenNumberFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver Min => ByCssSelector("[data-search-target='min'] > input").Wait().Find<TextBoxDriver>();
        public TextBoxDriver Max => ByCssSelector("[data-search-target='max'] > input").Wait().Find<TextBoxDriver>();
        public RadzenNumberFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenNumberFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenNumberFieldSearchDriver>();
    }
}
