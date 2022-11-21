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
  public void Scenario2() {
    // Test name: Scenario_2
    // Step # | name | target | value
    // 1 | open | /?x=ep&map=41.70907,44.79611,12,normal | 
    driver.Navigate().GoToUrl("https://wego.here.com//?x=ep&map=41.70907,44.79611,12,normal");
    // 2 | setWindowSize | 1550x838 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1550, 838);
    // 3 | click | css=.menu_access_btn | 
    driver.FindElement(By.CssSelector(".menu_access_btn")).Click();
    // 4 | mouseOver | css=.menu_access_btn | 
    {
      var element = driver.FindElement(By.CssSelector(".menu_access_btn"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 5 | mouseOut | css=.menu_access_btn | 
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    // 6 | click | css=.sign_in_out | 
    driver.FindElement(By.CssSelector(".sign_in_out")).Click();
    // 7 | selectFrame | index=0 | 
    driver.SwitchTo().Frame(0);
    // 8 | type | id=sign-in-password-encrypted | TestingReasons123!
    driver.FindElement(By.Id("sign-in-password-encrypted")).SendKeys("TestingReasons123!");
    // 9 | click | id=container-body | 
    driver.FindElement(By.Id("container-body")).Click();
    // 10 | click | id=container-body | 
    driver.FindElement(By.Id("container-body")).Click();
    // 11 | click | id=container-body | 
    driver.FindElement(By.Id("container-body")).Click();
    // 12 | click | id=container-body | 
    driver.FindElement(By.Id("container-body")).Click();
    // 13 | click | id=signInBtn | 
    driver.FindElement(By.Id("signInBtn")).Click();
    // 14 | selectFrame | relative=parent | 
    driver.SwitchTo().DefaultContent();
    // 15 | click | css=.input_search | 
    driver.FindElement(By.CssSelector(".input_search")).Click();
    // 16 | type | css=.input_search | Eindhoven
    driver.FindElement(By.CssSelector(".input_search")).SendKeys("Eindhoven");
    // 17 | sendKeys | css=.input_search | ${KEY_ENTER}
    driver.FindElement(By.CssSelector(".input_search")).SendKeys(Keys.Enter);
    // 18 | click | css=.star path | 
    driver.FindElement(By.CssSelector(".star path")).Click();
    // 19 | click | css=hr | 
    driver.FindElement(By.CssSelector("hr")).Click();
    // 20 | click | css=.collections_grid > .btn:nth-child(2) | 
    driver.FindElement(By.CssSelector(".collections_grid > .btn:nth-child(2)")).Click();
    // 21 | click | css=.input_search | 
    driver.FindElement(By.CssSelector(".input_search")).Click();
    // 22 | click | css=.input_search | 
    driver.FindElement(By.CssSelector(".input_search")).Click();
    // 23 | doubleClick | css=.input_search | 
    {
      var element = driver.FindElement(By.CssSelector(".input_search"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    // 24 | type | css=.input_search | Katowice
    driver.FindElement(By.CssSelector(".input_search")).SendKeys("Katowice");
    // 25 | sendKeys | css=.input_search | ${KEY_ENTER}
    driver.FindElement(By.CssSelector(".input_search")).SendKeys(Keys.Enter);
    // 26 | click | css=.menu_access_btn | 
    driver.FindElement(By.CssSelector(".menu_access_btn")).Click();
    // 27 | click | xpath=//a[contains(@href, '/collections')] | 
    driver.FindElement(By.XPath("//a[contains(@href, \'/collections\')]")).Click();
    // 28 | click | css=.count | 
    driver.FindElement(By.CssSelector(".count")).Click();
    // 29 | click | linkText=TEST | 
    driver.FindElement(By.LinkText("TEST")).Click();
    // 30 | mouseOver | css=.place_card:nth-child(1) > .image_box | 
    {
      var element = driver.FindElement(By.CssSelector(".place_card:nth-child(1) > .image_box"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 31 | mouseOut | css=.hover > .image_box | 
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    // 32 | mouseOver | css=.title_box | 
    {
      var element = driver.FindElement(By.CssSelector(".title_box"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 33 | mouseOut | css=.title_box | 
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    // 34 | click | css=.image_box | 
    driver.FindElement(By.CssSelector(".image_box")).Click();
    // 35 | click | css=.menu_access_btn | 
    driver.FindElement(By.CssSelector(".menu_access_btn")).Click();
    // 36 | click | linkText=Collections | 
    driver.FindElement(By.LinkText("Collections")).Click();
    // 37 | click | linkText=TEST | 
    driver.FindElement(By.LinkText("TEST")).Click();
    // 38 | mouseOver | css=.image_box | 
    {
      var element = driver.FindElement(By.CssSelector(".image_box"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 39 | click | css=.image_box | 
    driver.FindElement(By.CssSelector(".image_box")).Click();
    // 40 | click | css=.star path | 
    driver.FindElement(By.CssSelector(".star path")).Click();
    // 41 | click | css=.inner_box | 
    driver.FindElement(By.CssSelector(".inner_box")).Click();
    // 42 | mouseDownAt | css=.collections_grid > .btn:nth-child(2) | 33,14
    {
      var element = driver.FindElement(By.CssSelector(".collections_grid > .btn:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    // 43 | mouseMoveAt | css=.collections_grid > .btn:nth-child(2) | 33,14
    {
      var element = driver.FindElement(By.CssSelector(".collections_grid > .btn:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 44 | mouseUpAt | css=.collections_grid > .btn:nth-child(2) | 33,14
    {
      var element = driver.FindElement(By.CssSelector(".collections_grid > .btn:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    // 45 | click | css=.collections_grid > .btn:nth-child(2) | 
    driver.FindElement(By.CssSelector(".collections_grid > .btn:nth-child(2)")).Click();
    // 46 | click | css=.menu_access_btn | 
    driver.FindElement(By.CssSelector(".menu_access_btn")).Click();
    // 47 | click | css=.sign_in_out | 
    driver.FindElement(By.CssSelector(".sign_in_out")).Click();
  }
}
