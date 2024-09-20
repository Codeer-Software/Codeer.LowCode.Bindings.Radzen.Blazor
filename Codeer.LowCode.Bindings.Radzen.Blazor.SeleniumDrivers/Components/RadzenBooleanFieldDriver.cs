using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenBooleanFieldDriver : ComponentBase
    {
        public CheckBoxDriver Check => ByTagName("input").Wait();
        public IWebElement Label => ByTagName("label").Wait().Find();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadzenBooleanFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenBooleanFieldDriver(ElementFinder finder) => finder.Find<RadzenBooleanFieldDriver>();
    }
}
