// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTutorials.BaseClass;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass : BaseTest 
    {
        [Test]
        [Category("Smoke Testing")]
        public void TestMethod1()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium CSharp");
            driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _9xo6 _4jy3 _4jy1 selected _51sy']")).Click();
            IWebElement createAccountBtn = driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']"));
            createAccountBtn.Click();
            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@class='_9407 _5dba _9hk6 _8esg']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);
            element.SelectByText("Mar");
            element.SelectByValue("6");          
        }

        [Test]
        [Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium CSharp");
        }

        [Test]
        [Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium CSharp");
            Thread.Sleep(5000);
        }
    }
}
