using EATestProject.Model;
using OpenQA.Selenium;
using SeleniumXUnitBasic.Driver;
using SeleniumXUnitBasic.Extensions;

namespace EATestProject.Pages;

public class ProductPage : IProductPage
{
    private IWebDriver _driver;

    public ProductPage(IDriverFixture driverFixture)
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

    public Product GetProductDetails()
    {
        return new Product
        {
            Name = TxtName.Text,
            Description = TxtDescription.Text,
            Price = int.Parse(TxtPrice.Text),
            ProductType = (ProductType)Enum.Parse(typeof(ProductType), DdlProductType.GetAttribute("innerText"))
        };
    }
}