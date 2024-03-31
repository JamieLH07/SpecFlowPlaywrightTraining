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
        private readonly BasketPage _basketPage;

        public SauceAppAddProductSteps(Driver driver)
        {
            _driver = driver;
            _productPage = new ProductsPage(_driver.Page);
            _basketPage = new BasketPage(_driver.Page);
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

        [Then(@"I can then logout of the Application")]
        public async Task ThenICanThenLogoutOfTheApplication()
        {
            await _productPage.Logout();
        }

        [Then(@"Logout was successful")]
        public async Task ThenLogoutWasSuccessful()
        {
            var isLogoutSuccessful = await _productPage.IsLogoutSuccessful();
            isLogoutSuccessful.Should().BeTrue();
        }

        [Then(@"I am able to Navigate to the Basket")]
        public async Task ThenIAmAbleToNavigateToTheBasket()
        {
            await _productPage.NavigatetoBasket();
        }

        [Then(@"I can see products have been added to the Basket")]
        public async Task ThenICanSeeProductsHaveBeenAddedToTheBasket()
        {
            await _basketPage.IsBasketPageLoaded();
        }

    }
}
