using OpenQA.Selenium;

namespace SeleniumXUnitBasic.Extensions;

public class ColumnSpecialValue
{
    public IEnumerable<IWebElement>? ElementCollection { get; set; }
    public ControlType? ControlType { get; set; }
}