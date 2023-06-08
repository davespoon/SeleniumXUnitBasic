using OpenQA.Selenium;

namespace SeleniumXUnitBasic.Driver;

public interface IBrowserDriver
{
    IWebDriver ChromeDriver { get; }
    IWebDriver FirefoxDriver { get; }
}