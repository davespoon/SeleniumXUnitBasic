using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumXUnitBasic
{
    public class UnitTest1
    {
        IWebDriver driver;

        [Fact]
        public void Test1()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("http://localhost:5001/Product/List");
            var element = driver.FindElement(By.LinkText("Create"));
            element.Click();
            var select = new SelectElement(driver.FindElement(By.Id("ProductTypeId")));
            
            driver.Quit();
            
        }
    }
}