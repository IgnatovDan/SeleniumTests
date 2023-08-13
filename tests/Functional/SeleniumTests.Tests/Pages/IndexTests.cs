using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTests.Tests.Pages
{
    [TestClass]
    public class IndexTests
    {
        [TestMethod]
        public void IndexH1TextCorrect()
        {
            var chromeOptions = new ChromeOptions()
            {

            };
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--disable-gpu");
            chromeOptions.AddArgument("--headless");
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArgument("disable-infobars");
            chromeOptions.AddArgument("--no-sandbox");
            chromeOptions.AddArgument("--disable-setuid-sandbox");
            chromeOptions.AddArgument("--ignore-certificate-errors");

            using (var driver = new ChromeDriver(Environment.CurrentDirectory, chromeOptions))
            {
                driver.Navigate().GoToUrl("http://localhost:5200");
                var text = driver.FindElement(By.Id("testId"));

                Assert.AreEqual(expected: "Test h1 text", text.Text);
            }
        }
    }
}