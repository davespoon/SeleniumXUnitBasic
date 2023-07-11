using EATestBase.Driver;

namespace EATestBase.Settings;

public class TestSettings
{
    public BrowserType BrowserType { get; set; }
    public Uri AppUri { get; set; }
    public int Timeout { get; set; }
}