using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenNumberFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public IWebElement Slider => ByCssSelector(".rz-slider").Wait().Find();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadzenNumberFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenNumberFieldDriver(ElementFinder finder) => finder.Find<RadzenNumberFieldDriver>();
    }
}
