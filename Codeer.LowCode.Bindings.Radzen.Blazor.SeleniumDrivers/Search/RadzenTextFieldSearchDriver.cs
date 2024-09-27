using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenTextFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver Text => ByCssSelector("input.rz-textbox").Wait().Find<TextBoxDriver>();
        public RadzenDropDownDriver Match => ByCssSelector(".rz-dropdown").Wait().Find<RadzenDropDownDriver>();
        public RadzenTextFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenTextFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenTextFieldSearchDriver>();
    }
}
