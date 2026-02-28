using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenBooleanFieldDriver : ComponentBase
    {
        public RadzenToggleButtonDriver Toggle => ByCssSelector("button.rz-button.rz-toggle-button").Wait();
        public IWebElement CheckBox => ByCssSelector(".rz-chkbox .rz-chkbox-box").Wait().Find();
        public IWebElement Switch => ByCssSelector(".rz-switch .rz-switch-circle").Wait().Find();
        public IWebElement Label => ByTagName("label").Wait().Find();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();

        public bool Checked => GetChecked();

        public RadzenBooleanFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenBooleanFieldDriver(ElementFinder finder) => finder.Find<RadzenBooleanFieldDriver>();

        public void Edit(bool b)
        {
            if (Checked == b) return;

            if (HasElement("button.rz-button.rz-toggle-button"))
            {
                Toggle.Element.Click();
            }
            else if (HasElement(".rz-chkbox .rz-chkbox-box"))
            {
                CheckBox.Click();
            }
            else if (HasElement(".rz-switch .rz-switch-circle"))
            {
                Switch.Click();
            }
        }

        private bool GetChecked()
        {
            if (HasElement("button.rz-button.rz-toggle-button"))
            {
                return Toggle.IsChecked;
            }
            else if (HasElement(".rz-chkbox .rz-chkbox-box"))
            {
                return Element.FindElement(By.CssSelector(".rz-chkbox-box"))
                    .GetAttribute("class").Contains("rz-state-active");
            }
            else if (HasElement(".rz-switch"))
            {
                return Element.FindElement(By.CssSelector(".rz-switch"))
                    .GetAttribute("class").Contains("rz-switch-checked");
            }
            return false;
        }

        private bool HasElement(string cssSelector)
        {
            try
            {
                Element.FindElement(By.CssSelector(cssSelector));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
