using PlaywrightTrainingProject.Pages;
using SpecFlowPlaywrightTraining.Drivers;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowPlaywrightTraining.StepDefinitions
{
    [Binding]
    public sealed class SauceAppAddProductSteps
    {
        private readonly Driver _driver;
        private readonly ProductsPage _productPage;

        public SauceAppAddProductSteps(Driver driver)
        {
            _driver = driver;
            _productPage = new ProductsPage(_driver.Page);
        }

        [Then(@"I add all the products to the Basket")]
        public async Task ThenIAddAllTheProductsToTheBasket()
        {
            await _productPage.AddAllToBasket();
        }

        [Then(@"I can see that all products have been added to the Basket")]
        public async Task ThenICanSeeThatAllProductsHaveBeenAddedToTheBasket()
        {
            var isProductAdded = await _productPage.IsBasketUpdated();
            isProductAdded.Should().BeTrue();
        }



    }
}
