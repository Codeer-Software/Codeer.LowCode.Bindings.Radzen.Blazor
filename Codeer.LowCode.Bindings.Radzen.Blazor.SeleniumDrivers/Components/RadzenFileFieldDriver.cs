using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Components
{
    public class RadzenFileFieldDriver : ComponentBase
    {
        public IWebElement Input => ByTagName("input").Wait().Find();
        public AnchorDriver Download => ByTagName("a").Wait();
        public ButtonDriver Delete => ByTagName("button").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public IWebElement Image => ByTagName("img").Wait().Find();

        public void Upload(string attachFileFullPath)
        {
            Input.SendKeys(attachFileFullPath);
        }

        public RadzenFileFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadzenFileFieldDriver(ElementFinder finder) => finder.Find<RadzenFileFieldDriver>();
    }
}
