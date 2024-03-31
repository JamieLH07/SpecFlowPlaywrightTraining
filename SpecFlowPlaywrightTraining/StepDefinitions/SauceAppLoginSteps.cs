using PlaywrightTrainingProject.Pages;
using SpecFlowPlaywrightTraining.Drivers;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowPlaywrightTraining.StepDefinitions
{
    [Binding]
    public sealed class SauceAppLoginSteps
    {
        private readonly Driver _driver;
        private readonly LoginPage _loginPage;

        public SauceAppLoginSteps(Driver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver.Page);
        }

        [Given(@"I navigate to the application")]
        public void GivenINavigateToTheApplication()
        {
            _driver.Page.GotoAsync("https://www.saucedemo.com/");
        }

        [Given(@"I enter the following login details")]
        public async Task GivenIEnterTheFollowingLoginDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            await _loginPage.Login((string)data.UserName, (string)data.Password);
        }

        [Then(@"I see the Products list")]
        public async Task ThenISeeTheProductsList()
        {
            var isProductPresent = await _loginPage.IsProductTxtExists();
            isProductPresent.Should().BeTrue();
        }

        [Then(@"I see the login error message")]
        public async Task ThenISeeTheLoginErrorMessage()
        {
            var isErrorDisplayed = await _loginPage.IsErrorDisplayed();
            isErrorDisplayed.Should().BeTrue();
        }

    }
}
