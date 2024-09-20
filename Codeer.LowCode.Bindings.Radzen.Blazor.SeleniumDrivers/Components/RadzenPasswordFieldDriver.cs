using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenPasswordFieldDriver : ComponentBase
    {
        public TextBoxDriver Password => ByTagName("input:not(.password-confirm)").Wait();
        public TextBoxDriver PasswordConfirm => ByCssSelector("input.password-confirm").Wait();
        public RadzenPasswordFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenPasswordFieldDriver(ElementFinder finder) => finder.Find<RadzenPasswordFieldDriver>();
    }
}
