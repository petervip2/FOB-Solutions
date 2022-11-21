using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
public class SuiteTests : IDisposable {
  public IWebDriver driver {get; private set;}
  public IDictionary<String, Object> vars {get; private set;}
  public IJavaScriptExecutor js {get; private set;}
  public SuiteTests()
  {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<String, Object>();
  }
  public void Dispose()
  {
    driver.Quit();
  }
  [Fact]
  public void Scenario3() {
    // Test name: Scenario_3
    // Step # | name | target | value
    // 1 | open | https://www.gsmarena.com/ | 
    driver.Navigate().GoToUrl("https://www.gsmarena.com/");
    // 2 | setWindowSize | 1536x824 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1536, 824);
    // 3 | click | xpath=//input[@id='topsearch-text'] | 
    driver.FindElement(By.XPath("//input[@id=\'topsearch-text\']")).Click();
    // 4 | type | id=topsearch-text | Apple Iphone 14 Pro Max
    driver.FindElement(By.Id("topsearch-text")).SendKeys("Apple Iphone 14 Pro Max");
    // 5 | sendKeys | id=topsearch-text | ${KEY_ENTER}
    driver.FindElement(By.Id("topsearch-text")).SendKeys(Keys.Enter);
    // 6 | mouseOver | css=.pad-single | 
    {
      var element = driver.FindElement(By.CssSelector(".pad-single"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 7 | runScript | window.scrollTo(0,120.4000015258789) | 
    js.ExecuteScript("window.scrollTo(0,120.4000015258789)");
    // 8 | click | css=li img | 
    driver.FindElement(By.CssSelector("li img")).Click();
    // 9 | runScript | window.scrollTo(0,13.199999809265137) | 
    js.ExecuteScript("window.scrollTo(0,13.199999809265137)");
    // 10 | click | css=table:nth-child(12) tr:nth-child(3) > .nfo | 
    driver.FindElement(By.CssSelector("table:nth-child(12) tr:nth-child(3) > .nfo")).Click();
    // 11 | click | css=table:nth-child(12) tr:nth-child(3) > .nfo | 
    driver.FindElement(By.CssSelector("table:nth-child(12) tr:nth-child(3) > .nfo")).Click();
    // 12 | verifyElementPresent | xpath=//td[contains(.,'GPS')] | 
    {
      IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.XPath("//td[contains(.,\'GPS\')]"));
      Assert.True(elements.Count > 0);
    }
  }
}
