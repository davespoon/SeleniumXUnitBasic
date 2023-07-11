using OpenQA.Selenium;

namespace EATestBase.Driver;

public interface IDriverFixture
{
    IWebDriver Driver { get; }
}