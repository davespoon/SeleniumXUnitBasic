using OpenQA.Selenium;
using SeleniumXUnitBasic.Driver;
using SeleniumXUnitBasic.Extensions;
using SeleniumXUnitBasic.Settings;

namespace EATestProject.Pages;

public class HomePage : IHomePage
{
    private IWebDriver _driver;

    public HomePage(IDriverFixture driverFixture)
    {
        _driver = driverFixture.Driver;
    }

    public IWebElement LnkProduct => _driver.FindElement(By.LinkText("Product"));
    public IWebElement LnkCreate => _driver.FindElement(By.LinkText("Create"));

    public IWebElement TblList => _driver.FindElement(By.CssSelector(".table"));

    public void CreateProduct()
    {
        LnkProduct.Click();
        LnkCreate.Click();
    }


    public void PerformClickOnDetails(string name, string operation)
    {
        TblList.PerformActionOnCell("5", "Name", name, operation);
    }

    // public void Open()
    // {
    //     // _driver.Navigate().GoToUrl("http://localhost:5001/Product/List");
    //     _driver.Navigate().GoToUrl(_testSettings.AppUri);
    // }
}