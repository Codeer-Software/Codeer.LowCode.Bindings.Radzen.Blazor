using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenSelectListItemDriver : ComponentBase
    {
        public IWebElement Text => ByTagName("label").Wait().Find();
        public CheckBoxDriver CheckBox => ByTagName("input").Wait().Find<CheckBoxDriver>();
        public RadzenSelectListItemDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenSelectListItemDriver(ElementFinder finder) =>
            finder.Find<RadzenSelectListItemDriver>();
    }
}
