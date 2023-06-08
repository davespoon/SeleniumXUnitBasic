using OpenQA.Selenium;
using SeleniumXUnitBasic.Settings;
using static SeleniumXUnitBasic.Driver.BrowserDriver;

namespace SeleniumXUnitBasic.Driver;

public class DriverFixture : IDriverFixture
{
    private readonly IWebDriver _driver;
    private readonly IBrowserDriver _browserDriver;
    private readonly TestSettings _testSettings;

    public DriverFixture(IBrowserDriver browserDriver, TestSettings testSettings)
    {
        _testSettings = testSettings;
        _browserDriver = browserDriver;
        _driver = GetDriver();
    }

    public IWebDriver Driver => _driver;

    private IWebDriver GetDriver()
    {
        var driver = _browserDriver;
        return _testSettings.BrowserType switch
        {
            BrowserType.Chrome => driver.ChromeDriver,
            BrowserType.Firefox => driver.FirefoxDriver,
            _ => driver.ChromeDriver
        };
    }
}