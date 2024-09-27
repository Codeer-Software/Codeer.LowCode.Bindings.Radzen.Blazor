using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search
{
    public class RadzenFileFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver FileName => ByCssSelector("[data-search-target='filename']").Wait().Find<TextBoxDriver>();
        public RadzenDropDownDriver FileNameMatch => ByCssSelector("[data-search-target='filenamematch']").Wait().Find<RadzenDropDownDriver>();
        public TextBoxDriver MinFileSize => ByCssSelector("[data-search-target='min'] > input").Wait().Find<TextBoxDriver>();
        public TextBoxDriver MaxFileSize => ByCssSelector("[data-search-target='max'] > input").Wait().Find<TextBoxDriver>();
        public RadzenFileFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenFileFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadzenFileFieldSearchDriver>();
    }
}
