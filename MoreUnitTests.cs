using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightDemo
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class MoreUnitTests : PageTest
    {
        [Test]
        public async Task MainNav()
        {
            await Expect(Page).ToHaveURLAsync("https://playwright.dev/");
        }

        [SetUp]
        public async Task SetUp()
        {
            await Page.GotoAsync("https://playwright.dev/");
        }
    }
}
