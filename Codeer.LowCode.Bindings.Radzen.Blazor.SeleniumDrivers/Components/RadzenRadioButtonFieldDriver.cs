using Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenRadioButtonFieldDriver : ComponentBase
    {
        public RadzenRadioButtonDriver Input => ByCssSelector(".rz-radiobutton").Wait().Find<RadzenRadioButtonDriver>();
        public IWebElement Label => ByCssSelector("span.rz-radiobutton-label").Wait().Find();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadzenRadioButtonFieldDriver(IWebElement element) : base(element) { }

        public static implicit operator RadzenRadioButtonFieldDriver(ElementFinder finder) =>
            finder.Find<RadzenRadioButtonFieldDriver>();
    }
}
