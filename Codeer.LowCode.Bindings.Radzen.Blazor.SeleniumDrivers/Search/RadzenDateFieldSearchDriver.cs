using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components;
using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenDateFieldSearchDriver : ComponentBase
    {
        public RadzenDateFieldDriver StartRadzenDate => ByTagName("input:first-child").Wait().Find<RadzenDateFieldDriver>();
        public RadzenDateFieldDriver EndRadzenDate => ByTagName("input:last-child").Wait().Find<RadzenDateFieldDriver>();
        public RadzenDateFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenDateFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenDateFieldSearchDriver>();
    }
}
