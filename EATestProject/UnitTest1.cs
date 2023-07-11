using AutoFixture.Xunit2;
using EATestProject.Model;
using EATestProject.Pages;
using FluentAssertions;
using OpenQA.Selenium;
using EATestBase.Driver;

namespace EATestProject
{
    public class UnitTest1
    {
        IHomePage _homePage;

        IProductPage _productPage;
        // IWebDriver _driver;

        public UnitTest1(IHomePage homePage, IProductPage productPage
        // IDriverFixture driverFixture
        )
        {
            // _driver = driverFixture.Driver;
            _homePage = homePage;
            _productPage = productPage;
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
            _productPage.EnterProductDetails(product);
        }


        [Theory, AutoData]
        public void Test2(Product product)
        {
            product.Name = "Monitor";
            // _homePage.Open();
            _homePage.CreateProduct();
            _productPage.EnterProductDetails(product);

            _homePage.PerformClickOnSpecialValue(product.Name, "Details");
        }

        [Theory, AutoData]
        public void Test3(Product product)
        {
            product.Name = "Monitor";
            // _homePage.Open();
            _homePage.CreateProduct();
            _productPage.EnterProductDetails(product);

            _homePage.PerformClickOnSpecialValue(product.Name, "Details");
            var actualProduct = _productPage.GetProductDetails();

            actualProduct.Should().BeEquivalentTo(product, options => options.Excluding(x => x.ID));
        }
    }
}