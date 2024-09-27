using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenDateFieldDriver : ComponentBase
    {
        public RadzenDateDriver Input => ByCssSelector(".rz-datepicker > input").Wait().Find<RadzenDateDriver>();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadzenDateFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenDateFieldDriver(ElementFinder finder) => finder.Find<RadzenDateFieldDriver>();
    }
}
