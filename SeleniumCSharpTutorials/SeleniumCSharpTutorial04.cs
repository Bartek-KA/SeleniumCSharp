using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        public IWebDriver driver = null;

        [Test]
        [Author("Bartomiej", "bartek.kazior@gmail.com")]
        [Description("Facebook login verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(string urlName)
        {
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                //IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='emailadsc']"));
                emailTextField.SendKeys("Selenium CSharp");
                driver.Dispose();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\ryzua\\source\\repos\\SeleniumCSharp\\SeleniumCSharpTutorials\\Screenshots\\Screenshot1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver!= null)
                {
                    driver.Dispose();
                }
            }
            
        }

        static IList DataDrivenTesting()
        {
            ArrayList List = new ArrayList
            {
                "https://www.facebook.com/",
                //"https://www.youtube.com/",
                //"https://www.gmail.com"
            };

            return List;
        }
        //[Test]
        //[Author("Bartomiej", "bartek.kazior@gmail.com")]
        //[Description("Facebook login verify")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com/";
        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
        //    emailTextField.SendKeys("Selenium CSharp");
        //    driver.Dispose();
        //}
    }
}
