using PlaywrightTrainingProject.Pages;
using SpecFlowPlaywrightTraining.Drivers;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowPlaywrightTraining.StepDefinitions
{
    [Binding]
    public sealed class SauceAppTestSteps
    {
        private readonly Driver _driver;
        private readonly LoginPage _loginPage;

        public SauceAppTestSteps(Driver driver)
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
            var isExist = await _loginPage.IsProductTxtExists();
            isExist.Should().BeTrue();
        }
    }
}
