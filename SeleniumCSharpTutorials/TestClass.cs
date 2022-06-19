using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTutorials.BaseClass;


/// <summary>
/// Opracowane dla wersji:
/// Chrome: Wersja 102.0.5005.115 (Oficjalna wersja) (64-bitowa)
/// Firefox: Wersja 101.0.1 (64 bity)
/// </summary>

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
            try
            {
                driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _9xo6 _4jy3 _4jy1 selected _51sy']")).Click(); //Akceptowanie niezbędnych pojawiających się cookies
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailTextField.SendKeys("Selenium CSharp");
                IWebElement createAccountBtn = driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']"));
                createAccountBtn.Click();
                IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@class='_9407 _5dba _9hk6 _8esg']"));
                SelectElement element = new SelectElement(monthDropdownList);
                element.SelectByIndex(1);
                element.SelectByText("Mar");
                element.SelectByValue("6");
            }
                   
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
            Thread.Sleep(2000);
        }
    }
}
