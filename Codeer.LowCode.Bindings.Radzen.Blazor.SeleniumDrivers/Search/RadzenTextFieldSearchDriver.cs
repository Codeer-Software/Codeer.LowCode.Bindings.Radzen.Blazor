using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenTextFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver Text => ByTagName("input").Wait().Find<TextBoxDriver>();
        public DropDownListDriver Match => ByTagName("select").Wait().Find<DropDownListDriver>();
        public RadzenTextFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenTextFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenTextFieldSearchDriver>();
    }
}
