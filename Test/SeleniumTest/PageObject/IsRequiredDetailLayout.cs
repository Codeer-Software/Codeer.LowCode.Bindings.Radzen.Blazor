using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components;
using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class IsRequiredDetailLayout : ComponentBase
    {
        public LabelFieldDriver Header => ByCssSelector("div[data-name='Header']").Wait();
        public LabelFieldDriver CheckLabel => ByCssSelector("div[data-name='CheckLabel']").Wait();
        public BooleanFieldDriver Check => ByCssSelector("div[data-name='Check']").Wait();
        public LabelFieldDriver ToggleLabel => ByCssSelector("div[data-name='ToggleLabel']").Wait();
        public BooleanFieldDriver Toggle => ByCssSelector("div[data-name='Toggle']").Wait();
        public LabelFieldDriver SwitchLabel => ByCssSelector("div[data-name='SwitchLabel']").Wait();
        public BooleanFieldDriver Switch => ByCssSelector("div[data-name='Switch']").Wait();
        public LabelFieldDriver DateLabel => ByCssSelector("div[data-name='DateLabel']").Wait();
        public RadzenDateFieldDriver Date => ByCssSelector("div[data-name='Date']").Wait();
        public LabelFieldDriver DateTimeLabel => ByCssSelector("div[data-name='DateTimeLabel']").Wait();
        public RadzenDateTimeFieldDriver DateTime => ByCssSelector("div[data-name='DateTime']").Wait();
        public LabelFieldDriver LinkLabel => ByCssSelector("div[data-name='LinkLabel']").Wait();
        public RadzenLinkFieldDriver<LinkDataListLayout, LinkDataSearchLayout> Link => ByCssSelector("div[data-name='Link']").Wait();
        public LabelFieldDriver NumberLabel => ByCssSelector("div[data-name='NumberLabel']").Wait();
        public NumberFieldDriver Number => ByCssSelector("div[data-name='Number']").Wait();
        public LabelFieldDriver RadioLabel => ByCssSelector("div[data-name='RadioLabel']").Wait();
        public RadzenRadioButtonFieldDriver RadioA => ByCssSelector("div[data-name='RadioA']").Wait();
        public RadzenRadioButtonFieldDriver RadioB => ByCssSelector("div[data-name='RadioB']").Wait();
        public RadzenRadioButtonFieldDriver RadioC => ByCssSelector("div[data-name='RadioC']").Wait();
        public LabelFieldDriver SelectLabel => ByCssSelector("div[data-name='SelectLabel']").Wait();
        public RadzenSelectFieldDriver Select => ByCssSelector("div[data-name='Select']").Wait();
        public LabelFieldDriver SelectLinkLabel => ByCssSelector("div[data-name='SelectLinkLabel']").Wait();
        public RadzenSelectFieldDriver SelectLink => ByCssSelector("div[data-name='SelectLink']").Wait();
        public LabelFieldDriver TextLabel => ByCssSelector("div[data-name='TextLabel']").Wait();
        public TextFieldDriver Text => ByCssSelector("div[data-name='Text']").Wait();
        public LabelFieldDriver TimeLabel => ByCssSelector("div[data-name='TimeLabel']").Wait();
        public RadzenTimeFieldDriver Time => ByCssSelector("div[data-name='Time']").Wait();
        public LabelFieldDriver FileLabel => ByCssSelector("div[data-name='FileLabel']").Wait();
        public RadzenFileFieldDriver File => ByCssSelector("div[data-name='File']").Wait();
        public SubmitButtonFieldDriver Submit => ByCssSelector("div[data-name='Submit']").Wait();

        public IsRequiredDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator IsRequiredDetailLayout(ElementFinder finder) => finder.Find<IsRequiredDetailLayout>();
    }

    public class IsRequiredDetailPage : DetailPage<IsRequiredDetailLayout>
    {

        public IsRequiredDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class IsRequiredDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/IsRequired/")]
        public static IsRequiredDetailPage AttachIsRequiredDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/IsRequired/");
            return new IsRequiredDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<IsRequiredDetailLayout> AttachIsRequiredDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='IsRequired']").Wait();

    }

}
