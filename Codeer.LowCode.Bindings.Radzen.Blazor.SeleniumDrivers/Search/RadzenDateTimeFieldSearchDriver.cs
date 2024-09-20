using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components;
using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenDateTimeFieldSearchDriver : ComponentBase
    {
        public RadzenDateFieldDriver StartRadzenDate => ByTagName("input:first-child").Wait().Find<RadzenDateFieldDriver>();
        public RadzenDateFieldDriver EndRadzenDate => ByTagName("input:last-child").Wait().Find<RadzenDateFieldDriver>();
        public RadzenDateTimeFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenDateTimeFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenDateTimeFieldSearchDriver>();
    }
}
