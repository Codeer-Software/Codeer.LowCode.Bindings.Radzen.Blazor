using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenLinkFieldSearchDriver<TListLayout, TSearchLayout> : ComponentBase
        where TListLayout : ListLayoutBase
        where TSearchLayout : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public ButtonDriver Clear => ByCssSelector(".rz-form-field-content .rz-form-field-end button.rz-button-icon-only").Wait();
        public ButtonDriver Search => ByCssSelector(".rz-stack > button.rz-button-icon-only").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public SearchFieldDriver<TSearchLayout> LinkSearch => ByCssSelector("div[data-system='search-field']").Wait();
        public ListFieldDriver<TListLayout> LinkList => GetModal().ByCssSelector("div[data-system='list-field']").Wait();
        public RadzenLinkFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenLinkFieldSearchDriver<TListLayout, TSearchLayout>(ElementFinder finder) =>
            finder.Find<RadzenLinkFieldSearchDriver<TListLayout, TSearchLayout>>();
        private ElementFinder GetModal()
        {
            return new ElementFinder(base.Element.FindElement(By.XPath("/html/body")).FindElement(By.CssSelector("div.modal.show")));
        }
    }
}
