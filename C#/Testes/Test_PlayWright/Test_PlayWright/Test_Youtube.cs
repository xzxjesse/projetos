using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Xunit;

namespace Test_PlayWright
{
    public class Test_Acesso
    {
        [Fact]
        public async Task Test1_TituloGoogle()
        {
            using var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var page = await browser.NewPageAsync();

            await page.GotoAsync("https://www.google.com");

            string title = await page.TitleAsync();
            Assert.Equal("Google", title);

            await browser.CloseAsync();
        }

        [Fact]
        public async Task Test2_DirecionarSite()
        {
            using var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var page = await browser.NewPageAsync();

            await page.GotoAsync("https://www.google.com");

            await page.FillAsync("textarea[id=APjFqb]", "youtube");

            await page.PressAsync("textarea[id=APjFqb]", "Enter");

            await page.WaitForSelectorAsync("h3");

            var firstResult = await page.QuerySelectorAsync("h3");
            Assert.NotNull(firstResult);

            await firstResult.ClickAsync();

            await page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);

            string currentUrl = page.Url;
            Assert.Contains("youtube.com", currentUrl);

            await browser.CloseAsync();
        }

        [Fact]
        public async Task Test3_PesquisarVideo()
        {
            using var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var page = await browser.NewPageAsync();

            await page.GotoAsync("https://www.youtube.com");

            await page.WaitForSelectorAsync("input[id=search]", new PageWaitForSelectorOptions { State = WaitForSelectorState.Visible });

            await page.FocusAsync("input[id=search]");

            await page.Keyboard.TypeAsync("LEI DE MUFFIN");

            await page.Keyboard.PressAsync("Enter");

            await page.WaitForSelectorAsync("ytd-video-renderer", new PageWaitForSelectorOptions { Timeout = 60000 });

            var firstVideoTitleElement = await page.QuerySelectorAsync("ytd-video-renderer h3 a");
            var firstVideoTitle = await firstVideoTitleElement.InnerTextAsync();

            const string expectedTitle = "LEI DE MUFFIN - SCATOLOVE (Álbum Completo)";
            Assert.Contains(expectedTitle, firstVideoTitle);

            await browser.CloseAsync();
        }
    }
}
