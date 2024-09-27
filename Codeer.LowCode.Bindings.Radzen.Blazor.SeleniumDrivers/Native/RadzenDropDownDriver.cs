using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native
{
    public class RadzenDropDownDriver(IWebElement element) : ControlDriverBase(element)
    {
        public string Text => FindText();
        public string Id => Element.GetAttribute("id");

        public void Edit(string value)
        {
            Element.Click();

            var popoverContentElement = WebDriver.FindElement(By.CssSelector($"div#popup-{Id}"));
            IReadOnlyCollection<IWebElement> listItemElements = [];
            while (listItemElements.Count == 0)
            {
                Thread.Sleep(10);
                listItemElements = popoverContentElement.FindElements(By.CssSelector("li.rz-dropdown-item"));
            }

            foreach (var element in listItemElements)
            {
                var text = element.GetAttribute("aria-label");
                if (text == value)
                {
                    element.Click();
                    return;
                }
            }

            throw new InvalidOperationException($"The Value {value} could not found");
        }

        private string FindText()
        {
            var element = Element.FindElement(By.CssSelector(".rz-dropdown-label.rz-inputtext"));
            return element.Text;
        }
    }
}
