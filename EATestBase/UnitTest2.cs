using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumXUnitBasic.Driver;
using SeleniumXUnitBasic.DriverService;

namespace SeleniumXUnitBasic
{
    public class UnitTest2 : IDisposable
    {
        private readonly IWebDriver _driver;

        public UnitTest2(IDriverFixture driverFixture)
        {
            _driver = driverFixture.Driver;
        }

        [Fact]
        public void Test1()
        {
            _driver.Navigate().GoToUrl("http://localhost:5001/Product/List");
            var element = _driver.FindElement(By.LinkText("Create"));
            element.Click();
            var select = new SelectElement(_driver.FindElement(By.Id("ProductType")));
        }

        [Fact]
        public void Test2()
        {
            _driver.Navigate().GoToUrl("http://localhost:5001/Product/List");
            var element = _driver.FindElement(By.LinkText("Create"));
            element.Click();
            var select = new SelectElement(_driver.FindElement(By.Id("ProductType")));
        }

        public void Dispose()
        {
            _driver.Dispose();
        }
    }
}