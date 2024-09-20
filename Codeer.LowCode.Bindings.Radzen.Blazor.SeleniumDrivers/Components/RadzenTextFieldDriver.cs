using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenTextFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public TextAreaDriver TextArea => ByTagName("textarea").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadzenTextFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenTextFieldDriver(ElementFinder finder) => finder.Find<RadzenTextFieldDriver>();
    }
}
