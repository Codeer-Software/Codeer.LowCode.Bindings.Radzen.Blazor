using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenTimeFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver StartTime => ByTagName("input:first-child").Wait().Find<TextBoxDriver>();
        public TextBoxDriver EndTime => ByTagName("input:last-child").Wait().Find<TextBoxDriver>();
        public RadzenTimeFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenTimeFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenTimeFieldSearchDriver>();
    }
}
