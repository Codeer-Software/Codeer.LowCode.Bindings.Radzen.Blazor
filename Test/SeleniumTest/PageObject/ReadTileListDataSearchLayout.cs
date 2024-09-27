using Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Search;
using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ReadTileListDataSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public LabelFieldSearchDriver ListLabel => ByCssSelector("div[data-name='ListLabel']").Wait();
        public TileListFieldSearchDriver List => ByCssSelector("div[data-name='List']").Wait();
        public LabelFieldSearchDriver ListCheckLabel => ByCssSelector("div[data-name='ListCheckLabel']").Wait();
        public RadzenBooleanFieldSearchDriver List_Check => ByCssSelector("div[data-name='List.Check']").Wait();
        public LabelFieldSearchDriver ListToggleLabel => ByCssSelector("div[data-name='ListToggleLabel']").Wait();
        public RadzenBooleanFieldSearchDriver List_Toggle => ByCssSelector("div[data-name='List.Toggle']").Wait();
        public LabelFieldSearchDriver ListSwitchLabel => ByCssSelector("div[data-name='ListSwitchLabel']").Wait();
        public RadzenBooleanFieldSearchDriver List_Switch => ByCssSelector("div[data-name='List.Switch']").Wait();
        public LabelFieldSearchDriver ListDateLabel => ByCssSelector("div[data-name='ListDateLabel']").Wait();
        public RadzenDateFieldSearchDriver List_Date => ByCssSelector("div[data-name='List.Date']").Wait();
        public LabelFieldSearchDriver ListDateTimeLabel => ByCssSelector("div[data-name='ListDateTimeLabel']").Wait();
        public RadzenDateTimeFieldSearchDriver List_DateTime => ByCssSelector("div[data-name='List.DateTime']").Wait();
        public LabelFieldSearchDriver ListNumberLabel => ByCssSelector("div[data-name='ListNumberLabel']").Wait();
        public RadzenNumberFieldSearchDriver List_Number => ByCssSelector("div[data-name='List.Number']").Wait();
        public LabelFieldSearchDriver ListRadioGroupLabel => ByCssSelector("div[data-name='ListRadioGroupLabel']").Wait();
        public RadzenRadioGroupFieldSearchDriver List_RadioGroup => ByCssSelector("div[data-name='List.RadioGroup']").Wait();
        public LabelFieldSearchDriver ListSelectLabel => ByCssSelector("div[data-name='ListSelectLabel']").Wait();
        public RadzenSelectFieldSearchDriver List_Select => ByCssSelector("div[data-name='List.Select']").Wait();
        public LabelFieldSearchDriver ListTextLabel => ByCssSelector("div[data-name='ListTextLabel']").Wait();
        public RadzenTextFieldSearchDriver List_Text => ByCssSelector("div[data-name='List.Text']").Wait();
        public LabelFieldSearchDriver ListTimeLabel => ByCssSelector("div[data-name='ListTimeLabel']").Wait();
        public RadzenTimeFieldSearchDriver List_Time => ByCssSelector("div[data-name='List.Time']").Wait();
        public LabelFieldSearchDriver ListFileLabel => ByCssSelector("div[data-name='ListFileLabel']").Wait();
        public RadzenFileFieldSearchDriver List_File => ByCssSelector("div[data-name='List.File']").Wait();

        public ReadTileListDataSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator ReadTileListDataSearchLayout(ElementFinder finder) => finder.Find<ReadTileListDataSearchLayout>();
    }

}
