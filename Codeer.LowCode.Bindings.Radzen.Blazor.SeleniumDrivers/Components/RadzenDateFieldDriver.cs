using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenDateFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadzenDateFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenDateFieldDriver(ElementFinder finder) => finder.Find<RadzenDateFieldDriver>();
    }
}
