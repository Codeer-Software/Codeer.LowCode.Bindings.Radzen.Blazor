using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenLinkFieldDriver<TListLayout, TSearchLayout>  : ComponentBase where TListLayout : ListLayoutBase
        where TSearchLayout : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public ButtonDriver Clear => ByCssSelector(".input-group button.btn-close").Wait();
        public ButtonDriver Search => ByCssSelector(".input-group button:has(.bi-search)").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public SearchFieldDriver<TSearchLayout> LinkSearch => ByCssSelector("div[data-system='search-field']").Wait();
        public ListFieldDriver<TListLayout> LinkList => ByCssSelector("div[data-system='list-field']").Wait();
        public RadzenLinkFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenLinkFieldDriver<TListLayout, TSearchLayout>(ElementFinder finder) => finder.Find<RadzenLinkFieldDriver<TListLayout, TSearchLayout>>();
    }
}
