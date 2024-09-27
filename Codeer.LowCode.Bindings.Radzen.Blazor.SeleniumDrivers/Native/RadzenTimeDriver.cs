using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native
{
    public class RadzenTimeDriver : TimeDriver
    {
        public RadzenTimeDriver(IWebElement element) : base(element) { }
        public RadzenTimeDriver(IWebElement element, Action wait) : base(element, wait) { }

        public void Edit(int hour, int minute)
        {
            Element.Show();
            Element.Focus();
            JS.ExecuteScript("arguments[0].select();", Element);
            Element.SendKeys(hour.ToString());
            Element.SendKeys(":");
            Element.SendKeys(minute.ToString());
            try
            {
                JS.ExecuteScript("");
            }
            catch { }

            Wait?.Invoke();
        }

        public void Clear()
        {
            Element.Show();
            Element.Focus();
            JS.ExecuteScript("arguments[0].select();", Element);
            Element.SendKeys(Keys.Delete);
            try
            {
                JS.ExecuteScript("");
            }
            catch { }

            Wait?.Invoke();
        }
    }
}
