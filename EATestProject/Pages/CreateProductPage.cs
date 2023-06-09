using EATestProject.Model;
using OpenQA.Selenium;
using SeleniumXUnitBasic.Driver;
using SeleniumXUnitBasic.Extensions;

namespace EATestProject.Pages;

public class CreateProductPage : ICreateProductPage
{
    private IWebDriver _driver;

    public CreateProductPage(IDriverFixture driverFixture)
    {
        _driver = driverFixture.Driver;
    }

    public IWebElement TxtName => _driver.FindElement(By.Id("Name"));
    public IWebElement TxtDescription => _driver.FindElement(By.Id("Description"));
    public IWebElement TxtPrice => _driver.FindElement(By.Id("Price"));
    public IWebElement DdlProductType => _driver.FindElement(By.Id("ProductType"));
    public IWebElement BtnCreate => _driver.FindElement(By.Id("Create"));


    public void EnterProductDetails(Product product)
    {
        TxtName.SendKeys(product.Name);
        TxtDescription.SendKeys(product.Description);
        TxtPrice.SendKeys(product.Price.ToString());
        DdlProductType.SelectDropDownByText(product.ProductType.ToString());
        BtnCreate.Click();
    }
}