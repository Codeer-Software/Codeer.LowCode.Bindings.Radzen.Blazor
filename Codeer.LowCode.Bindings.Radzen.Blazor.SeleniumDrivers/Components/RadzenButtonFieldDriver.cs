using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenButtonFieldDriver : ComponentBase
    {
        public ButtonDriver Button => ByTagName("button").Wait();
        public RadzenButtonFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenButtonFieldDriver(ElementFinder finder) => finder.Find<RadzenButtonFieldDriver>();
    }
}
