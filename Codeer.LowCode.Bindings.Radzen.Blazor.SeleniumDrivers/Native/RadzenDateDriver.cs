﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers.Native
{
    public class RadzenDateDriver : DateDriver
    {
        public RadzenDateDriver(IWebElement element) : base(element) { }
        public RadzenDateDriver(IWebElement element, Action wait) : base(element, wait) { }

        public new void Edit(int year, int month, int day)
        {
            Element.Show();
            Element.Focus();
            JS.ExecuteScript("arguments[0].select();", Element);
            Element.SendKeys(year.ToString());
            Element.SendKeys("/");
            Element.SendKeys(month.ToString());
            Element.SendKeys("/");
            Element.SendKeys(day.ToString());
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