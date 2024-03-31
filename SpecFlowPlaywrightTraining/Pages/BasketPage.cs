using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightTrainingProject.Pages
{
    public class BasketPage
    {
        private IPage _page;
        public BasketPage(IPage page) => _page = page;
        private ILocator _txtYourCart => _page.Locator("css=#header_container > div.header_secondary_container > span");
        private ILocator _btnContinueShopping => _page.Locator("continue-shopping");
        private ILocator _btnCheckout => _page.Locator("checkout");
        private ILocator _btnLeftPanel => _page.Locator("#react-burger-menu-btn");
        private ILocator _btnLogout => _page.Locator("#logout_sidebar_link");
        private ILocator _btnLogin => _page.Locator("#login-button");
        private ILocator _txtBackpackCart => _page.Locator("css=#item_4_title_link > div");
        private ILocator _txtBikeCart => _page.Locator("css=#item_0_title_link > div");
        private ILocator _txtShirtCart => _page.Locator("css=#item_1_title_link > div");
        private ILocator _txtJacketCart => _page.Locator("css=#item_5_title_link > div");
        private ILocator _txtOnesieCart => _page.Locator("css=#item_2_title_link > div");
        private ILocator _txtRedTCart => _page.Locator("css=#item_3_title_link > div"); 


        public async Task<bool> IsBasketPageLoaded() => await _txtYourCart.IsVisibleAsync();
 
        public async Task Logout()
        {
            await _btnLeftPanel.ClickAsync();
            await _btnLogout.ClickAsync();
        }
        public async Task<bool> IsLogoutSuccessful() => await _btnLogin.IsVisibleAsync();

        public async Task CheckAddedProducts()
        {
            await _txtBackpackCart.IsVisibleAsync();
            await _txtBikeCart.IsVisibleAsync();
            await _txtShirtCart.IsVisibleAsync();
            await _txtJacketCart.IsVisibleAsync();
            await _txtOnesieCart.IsVisibleAsync();
            await _txtRedTCart.IsVisibleAsync();
        }


    }
}
