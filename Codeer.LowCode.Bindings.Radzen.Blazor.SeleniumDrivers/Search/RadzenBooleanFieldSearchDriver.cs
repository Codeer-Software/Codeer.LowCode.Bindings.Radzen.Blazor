using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenBooleanFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait().Find<DropDownListDriver>();
        public RadzenBooleanFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenBooleanFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenBooleanFieldSearchDriver>();
    }
}
