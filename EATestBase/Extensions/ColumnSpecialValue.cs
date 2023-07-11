using OpenQA.Selenium;

namespace EATestBase.Extensions;

public class ColumnSpecialValue
{
    public IEnumerable<IWebElement>? ElementCollection { get; set; }
    public ControlType? ControlType { get; set; }
}