using EATestBase.Settings;
using OpenQA.Selenium;

namespace EATestBase.Driver;

public class DriverFixture : IDriverFixture, IDisposable
{
    private readonly IWebDriver _driver;
    private readonly IBrowserDriver _browserDriver;
    private readonly TestSettings _testSettings;

    public DriverFixture(IBrowserDriver browserDriver, TestSettings testSettings)
    {
        _testSettings = testSettings;
        _browserDriver = browserDriver;
        _driver = GetDriver();
        _driver.Navigate().GoToUrl(_testSettings.AppUri);
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


    public void Dispose()
    {
        Driver.Dispose();
    }
}