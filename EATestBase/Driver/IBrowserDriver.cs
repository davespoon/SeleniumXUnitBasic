using OpenQA.Selenium;

namespace SeleniumXUnitBasic.DriverService;

public interface IBrowserDriver
{
    IWebDriver ChromeDriver { get; }
    IWebDriver FirefoxDriver { get; }
}