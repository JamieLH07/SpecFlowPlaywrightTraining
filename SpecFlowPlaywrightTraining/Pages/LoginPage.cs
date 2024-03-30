﻿using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightTrainingProject.Pages
{
    public class LoginPage
    {
        private IPage _page;
        public LoginPage(IPage page) => _page = page;
        private ILocator _txtuserName => _page.Locator("#user-name");
        private ILocator _txtpassWord => _page.Locator("#password");
        private ILocator _btnLogin => _page.Locator("input", new PageLocatorOptions { HasTextString = "Login" });
        private ILocator _txtProducts => _page.Locator("text='Products'");


        public async Task Login(string userName, string Password)
        {

            await _txtuserName.FillAsync(userName);
            await _txtpassWord.FillAsync(Password);
            await _btnLogin.ClickAsync();

        }

        public async Task<bool> IsProductTxtExists() => await _txtProducts.IsVisibleAsync();

    }
}
