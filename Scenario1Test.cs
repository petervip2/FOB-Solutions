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
  public void Scenario1() {
    // Test name: Scenario_1
    // Step # | name | target | value
    // 1 | open | /?map=52.21461,15.74152,6,normal | 
    driver.Navigate().GoToUrl("https://wego.here.com//?map=52.21461,15.74152,6,normal");
    // 2 | setWindowSize | 1550x838 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1550, 838);
    // 3 | click | css=.input_search | 
    driver.FindElement(By.CssSelector(".input_search")).Click();
    // 4 | type | css=.input_search | Katowice
    driver.FindElement(By.CssSelector(".input_search")).SendKeys("Katowice");
    // 5 | sendKeys | css=.input_search | ${KEY_ENTER}
    driver.FindElement(By.CssSelector(".input_search")).SendKeys(Keys.Enter);
    // 6 | click | css=.btn_directions_cta > .btn_block__icon | 
    driver.FindElement(By.CssSelector(".btn_directions_cta > .btn_block__icon")).Click();
    // 7 | click | id=itinerary_item_input_0 | 
    driver.FindElement(By.Id("itinerary_item_input_0")).Click();
    // 8 | type | id=itinerary_item_input_0 | Warszawa
    driver.FindElement(By.Id("itinerary_item_input_0")).SendKeys("Warszawa");
    // 9 | sendKeys | id=itinerary_item_input_0 | ${KEY_ENTER}
    driver.FindElement(By.Id("itinerary_item_input_0")).SendKeys(Keys.Enter);
    // 10 | click | css=.route_card_right | 
    driver.FindElement(By.CssSelector(".route_card_right")).Click();
    // 11 | click | css=.close_button | 
    driver.FindElement(By.CssSelector(".close_button")).Click();
    // 12 | click | css=.mode_car | 
    driver.FindElement(By.CssSelector(".mode_car")).Click();
    // 13 | click | css=.actionable:nth-child(2) .unit:nth-child(4) | 
    driver.FindElement(By.CssSelector(".actionable:nth-child(2) .unit:nth-child(4)")).Click();
    // 14 | click | css=.close_button | 
    driver.FindElement(By.CssSelector(".close_button")).Click();
    // 15 | mouseOver | css=.mode_publicTransport | 
    {
      var element = driver.FindElement(By.CssSelector(".mode_publicTransport"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 16 | click | css=.mode_publicTransport | 
    driver.FindElement(By.CssSelector(".mode_publicTransport")).Click();
    // 17 | mouseOut | css=.mode_publicTransport | 
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    // 18 | click | css=.mode_taxi | 
    driver.FindElement(By.CssSelector(".mode_taxi")).Click();
    // 19 | click | css=.mode_bicycle | 
    driver.FindElement(By.CssSelector(".mode_bicycle")).Click();
    // 20 | mouseOver | css=.mode_bicycle | 
    {
      var element = driver.FindElement(By.CssSelector(".mode_bicycle"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 21 | mouseOut | css=.mode_bicycle | 
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    // 22 | click | css=.mode_pedestrian | 
    driver.FindElement(By.CssSelector(".mode_pedestrian")).Click();
    // 23 | click | css=.actionable:nth-child(1) .route_card_right | 
    driver.FindElement(By.CssSelector(".actionable:nth-child(1) .route_card_right")).Click();
    // 24 | click | css=.close_button | 
    driver.FindElement(By.CssSelector(".close_button")).Click();
    // 25 | click | css=.actionable:nth-child(2) .inner_via > span | 
    driver.FindElement(By.CssSelector(".actionable:nth-child(2) .inner_via > span")).Click();
    // 26 | click | css=.close_button | 
    driver.FindElement(By.CssSelector(".close_button")).Click();
    // 27 | click | css=.mode_carShare | 
    driver.FindElement(By.CssSelector(".mode_carShare")).Click();
  }
}
