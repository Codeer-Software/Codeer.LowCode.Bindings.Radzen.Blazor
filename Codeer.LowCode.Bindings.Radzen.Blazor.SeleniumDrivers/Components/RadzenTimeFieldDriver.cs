using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenTimeFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByCssSelector("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadzenTimeFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenTimeFieldDriver(ElementFinder finder) => finder.Find<RadzenTimeFieldDriver>();
    }
}
