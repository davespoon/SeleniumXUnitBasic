using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumXUnitBasic.DriverService;

public class BrowserDriver : IBrowserDriver
{
    public IWebDriver ChromeDriver
    {
        get
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }
    }

    public IWebDriver FirefoxDriver
    {
        get
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver();
        }
    }

    public enum BrowserType
    {
        Chrome,
        Firefox
    }
}