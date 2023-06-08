
using SeleniumXUnitBasic.Driver;

namespace SeleniumXUnitBasic.Settings;

public class TestSettings
{
    public BrowserDriver.BrowserType BrowserType { get; set; }
    public string Uri { get; set; }
    public Uri AppUri { get; set; }
    public int Timeout { get; set; }
}