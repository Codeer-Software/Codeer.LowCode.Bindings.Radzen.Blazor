using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenRadioGroupFieldSearchDriver : ComponentBase
    {
        public RadzenDropDownDriver Select => ByCssSelector(".rz-dropdown").Wait().Find<RadzenDropDownDriver>();
        public RadzenToggleButtonDriver IsNot => ByCssSelector(".rz-button.rz-toggle-button").Wait().Find<RadzenToggleButtonDriver>();
        public ItemsControlDriver<RadzenSelectListItemDriver> MultipleSelect =>
            ByCssSelector("div.input-group .select-list").Wait().Find<ItemsControlDriver<RadzenSelectListItemDriver>>();
        public RadzenRadioGroupFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenRadioGroupFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenRadioGroupFieldSearchDriver>();
    }
}
