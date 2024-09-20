using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenRadioButtonFieldDriver : ComponentBase
    {
        public CheckBoxDriver Input => ByTagName("input").Wait();
        public IWebElement Label => ByTagName("label").Wait().Find();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadzenRadioButtonFieldDriver(IWebElement element) : base(element) { }

        public static implicit operator RadzenRadioButtonFieldDriver(ElementFinder finder) =>
            finder.Find<RadzenRadioButtonFieldDriver>();
    }
}
