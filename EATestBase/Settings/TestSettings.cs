using SeleniumXUnitBasic.Driver;

namespace SeleniumXUnitBasic.Settings;

public class TestSettings
{
    public BrowserType BrowserType { get; set; }
    public Uri AppUri { get; set; }
    public int Timeout { get; set; }
}