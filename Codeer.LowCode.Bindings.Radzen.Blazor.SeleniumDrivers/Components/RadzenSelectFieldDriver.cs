using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenSelectFieldDriver : ComponentBase
    {
        public RadzenDropDownDriver Select => ByCssSelector(".rz-dropdown").Wait().Find<RadzenDropDownDriver>();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadzenSelectFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenSelectFieldDriver(ElementFinder finder) => finder.Find<RadzenSelectFieldDriver>();
    }
}
