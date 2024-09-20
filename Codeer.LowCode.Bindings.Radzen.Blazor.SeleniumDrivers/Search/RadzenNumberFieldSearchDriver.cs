using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenNumberFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver Min => ByTagName("input:first-child").Wait().Find<TextBoxDriver>();
        public TextBoxDriver Max => ByTagName("input:last-child").Wait().Find<TextBoxDriver>();
        public RadzenNumberFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenNumberFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenNumberFieldSearchDriver>();
    }
}
