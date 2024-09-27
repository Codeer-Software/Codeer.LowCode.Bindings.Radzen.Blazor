using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenDateTimeFieldDriver : ComponentBase
    {
        public RadzenDateTimeDriver Input => ByCssSelector(".rz-datepicker > input").Wait().Find<RadzenDateTimeDriver>();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadzenDateTimeFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenDateTimeFieldDriver(ElementFinder finder) => finder.Find<RadzenDateTimeFieldDriver>();
    }
}
