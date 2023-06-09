using AutoFixture.Xunit2;
using EATestProject.Model;
using EATestProject.Pages;
using OpenQA.Selenium;
using SeleniumXUnitBasic.Driver;

namespace EATestProject
{
    public class UnitTest1
    {
        IHomePage _homePage;

        ICreateProductPage _createProductPage;
        // IWebDriver _driver;

        public UnitTest1(IHomePage homePage, ICreateProductPage createProductPage
            // IDriverFixture driverFixture
        )
        {
            // _driver = driverFixture.Driver;
            _homePage = homePage;
            _createProductPage = createProductPage;
        }


        [Fact]
        public void CreateProductTest()
        {
            var product = new Product
            {
                Description = "TestProduct",
                Name = "TestProductName",
                Price = 7327,
                ProductType = ProductType.EXTERNAL
            };

            // _homePage.Open();
            _homePage.CreateProduct();
            _createProductPage.EnterProductDetails(product);
        }


        [Theory, AutoData]
        public void Test2(Product product)
        {
            // _homePage.Open();
            _homePage.CreateProduct();
            _createProductPage.EnterProductDetails(product);
        }

        // [Fact]
        // public void Test2()
        // {
        //     _driver.Navigate().GoToUrl("http://localhost:5001/Product/List");
        //     var element = _driver.FindElement(By.LinkText("Create"));
        //     element.Click();
        //     var select = new SelectElement(_driver.FindElement(By.Id("ProductType")));
        // }
    }
}