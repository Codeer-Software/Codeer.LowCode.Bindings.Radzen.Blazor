using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenBooleanFieldDriver : ComponentBase
    {
        public RadzenToggleButtonDriver Toggle => ByCssSelector("button.rz-button.rz-toggle-button").Wait();
        public IWebElement Label => ByTagName("label").Wait().Find();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();

        public bool Checked => GetChecked();

        public RadzenBooleanFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenBooleanFieldDriver(ElementFinder finder) => finder.Find<RadzenBooleanFieldDriver>();

        public void Edit(bool b)
        {
            if (Toggle.IsChecked == b) return;
            Toggle.Element.Click();
        }

        private bool GetChecked() => Toggle.IsChecked;
    }
}
