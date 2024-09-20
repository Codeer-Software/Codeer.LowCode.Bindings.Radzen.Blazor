using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenSelectFieldDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadzenSelectFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenSelectFieldDriver(ElementFinder finder) => finder.Find<RadzenSelectFieldDriver>();
    }
}
