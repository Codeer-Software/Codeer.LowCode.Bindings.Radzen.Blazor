using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenIdFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadzenIdFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenIdFieldDriver(ElementFinder finder) => finder.Find<RadzenIdFieldDriver>();
    }
}
