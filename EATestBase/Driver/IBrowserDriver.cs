using OpenQA.Selenium;

namespace EATestBase.Driver;

public interface IBrowserDriver
{
    IWebDriver ChromeDriver { get; }
    IWebDriver FirefoxDriver { get; }
}