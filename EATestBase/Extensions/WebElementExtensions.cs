using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumXUnitBasic.Extensions
{
    public static class WebElementExtensions
    {
        public static void SelectDropDownByText(this IWebElement webElement, string text)
        {
            var select = new SelectElement(webElement);
            select.SelectByText(text);
        }

        public static void SelectDropDownByIndex(this IWebElement webElement, int index)
        {
            var select = new SelectElement(webElement);
            select.SelectByIndex(index);
        }

        public static void SelectDropDownByValue(this IWebElement webElement, string value)
        {
            var select = new SelectElement(webElement);
            select.SelectByValue(value);
        }
    }
}
