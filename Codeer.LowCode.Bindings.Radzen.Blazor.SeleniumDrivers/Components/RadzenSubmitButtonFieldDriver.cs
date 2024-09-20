using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenSubmitButtonFieldDriver : ComponentBase
    {
        public ButtonDriver Submit => ByTagName("button").Wait();
        public RadzenSubmitButtonFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenSubmitButtonFieldDriver(ElementFinder finder) =>
            finder.Find<RadzenSubmitButtonFieldDriver>();
    }
}
