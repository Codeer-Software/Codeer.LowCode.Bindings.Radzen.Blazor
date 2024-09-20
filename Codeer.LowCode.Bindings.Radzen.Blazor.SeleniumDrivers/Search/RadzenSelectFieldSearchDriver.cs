using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenSelectFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait().Find<DropDownListDriver>();
        public CheckBoxDriver IsInverted => ByCssSelector(".input-group + div input[type='checkbox']").Wait().Find<CheckBoxDriver>();
        public ItemsControlDriver<RadzenSelectListItemDriver> MultipleSelect => ByCssSelector("div.input-group .select-list").Wait().Find<ItemsControlDriver<RadzenSelectListItemDriver>>();
        public RadzenSelectFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenSelectFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenSelectFieldSearchDriver>();
    }
}
