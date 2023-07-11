﻿using EABddTests.Model;
using EABddTests.Pages;
using FluentAssertions;
using TechTalk.SpecFlow.Assist;

namespace EABddTests.Steps;

[Binding]
public sealed class ProductSteps
{
    private readonly ScenarioContext _scenarioContext;
    private readonly IHomePage _homePage;
    private readonly IProductPage _productPage;

    public ProductSteps(ScenarioContext scenarioContext, IHomePage homePage, IProductPage productPage)
    {
        _scenarioContext = scenarioContext;
        _homePage = homePage;
        _productPage = productPage;
    }


    [Given(@"I click the Product menu")]
    public void GivenIClickTheProductMenu()
    {
        _homePage.ClickProduct();
    }

    [Given(@"I click the ""(.*)"" link")]
    public void GivenIClickTheLink(string create)
    {
        _homePage.ClickCreate();
    }

    [Given(@"I create product with following details")]
    public void GivenICreateProductWithFollowingDetails(Table table)
    {
        var product = table.CreateInstance<Product>();
        _productPage.EnterProductDetails(product);
        _scenarioContext.Set<Product>(product);
    }

    [When(@"I click the details link of the newly created product")]
    public void WhenIClickTheDetailsLinkOfTheNewlyCreatedProduct()
    {
        var product = _scenarioContext.Get<Product>();
        _homePage.PerformClickOnSpecialValue(product.Name, "Details");
    }

    [Then(@"I see all the product details are created as expected")]
    public void ThenISeeAllTheProductDetailsAreCreatedAsExpected()
    {
        var product = _scenarioContext.Get<Product>();
        var actualProduct = _productPage.GetProductDetails();
        actualProduct.Should().BeEquivalentTo(product, options => options.Excluding(x => x.ID));
    }
}