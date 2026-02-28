using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components;
using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class IsRequiredListLayout : ListLayoutBase
    {
        public RadzenBooleanFieldDriver Check => ByCssSelector("td[data-name='Check']").Wait();
        public RadzenBooleanFieldDriver Toggle => ByCssSelector("td[data-name='Toggle']").Wait();
        public RadzenBooleanFieldDriver Switch => ByCssSelector("td[data-name='Switch']").Wait();
        public RadzenDateFieldDriver Date => ByCssSelector("td[data-name='Date']").Wait();
        public RadzenDateTimeFieldDriver DateTime => ByCssSelector("td[data-name='DateTime']").Wait();
        public RadzenLinkFieldDriver<LinkDataListLayout, LinkDataSearchLayout> Link => ByCssSelector("td[data-name='Link']").Wait();
        public RadzenNumberFieldDriver Number => ByCssSelector("td[data-name='Number']").Wait();
        public RadioGroupFieldDriver RadioGroup => ByCssSelector("td[data-name='RadioGroup']").Wait();
        public RadzenSelectFieldDriver Select => ByCssSelector("td[data-name='Select']").Wait();
        public RadzenSelectFieldDriver SelectLink => ByCssSelector("td[data-name='SelectLink']").Wait();
        public RadzenTextFieldDriver Text => ByCssSelector("td[data-name='Text']").Wait();
        public RadzenTimeFieldDriver Time => ByCssSelector("td[data-name='Time']").Wait();
        public RadzenFileFieldDriver File => ByCssSelector("td[data-name='File']").Wait();

        public IsRequiredListLayout(IWebElement element) : base(element) { }

        public static implicit operator IsRequiredListLayout(ElementFinder finder) => finder.Find<IsRequiredListLayout>();
    }

    public class IsRequiredListPage : ListPage<IsRequiredListLayout, IsRequiredSearchLayout>
    {

        public IsRequiredListPage(IWebDriver driver) : base(driver) { }

    }

    public static class IsRequiredListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/IsRequired")]
        public static IsRequiredListPage AttachIsRequiredListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/IsRequired");
            return new IsRequiredListPage(driver);
        }

    }

}
