using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenRadioGroupFieldDriver : ComponentBase
    {
        public IWebElement Value => ByTagName("span").Wait().Find();
        public RadzenRadioGroupFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenRadioGroupFieldDriver(ElementFinder finder) => finder.Find<RadzenRadioGroupFieldDriver>();
    }
}
