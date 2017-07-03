using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IPageTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the page required");
            string result = Console.ReadLine();
            IWebDriver driver = new ChromeDriver();

            //Switch solution to create page object based on text response
            bool containsValue = false;
            switch (result) {
                case "Home Page":
                    if (new HomePage(driver).Load().PageTitle == result) {
                        containsValue = true;
                    }
                    break;
                case "Login Page":
                    if (new LoginPage(driver).Load().PageTitle == result) {
                        containsValue = true;
                    }
                    break;
                case "Apprentice Page":
                    if (new ApprenticePage(driver).Load().PageTitle == result) {
                        containsValue = true;
                    }
                    break;
                case "Apprentice EPA Page":
                    if (new ApprenticeEpaPage(driver).Load().PageTitle == result) {
                        containsValue = true;
                    }
                    break;
                default:
                    containsValue = false;
                    break;
            }
            Assert.IsTrue(containsValue);

            //Dictionary solution
            Assert.IsTrue(LoadPageAndCheckTitle(driver, result));

            /* **********************************************
             * List of perceived code smells and requirements
             * **********************************************
             * - Could the design be changed to reduce the code in the switch or dictionary?
             * 
             * - If you wanted to return the page used in the switch or dictionary how might you store this?
             *   + If you can store it, how might you pass it into ApprenticeTests or LoginTests if it is of the correct type? 
             *   Thus avoiding potentially initialising the arguments on apprenticeTests or loginTests twice.
             *   
             * - Possible to allow ApprenticeTests/LoginTests access to the Control's on the pages (e.g. ApprenticePage.ForenameField) 
             * without exposing them publicly?
             * 
             * - It feels a little circular to pass in a Control on a subclass of BasePage to a method on BasePage
             * (e.g. apprenticeEpaPage.Click(apprenticeEpaPage.SubmitBtn);). My project requires this chaining/fluency. It might
             * not be too much of an issue.
             * 
             * These issues were identified when I noticed performance issues in my real world application from 
             * initialising pages multiple times. 
             */
        }

        private static readonly Dictionary<string, Func<IWebDriver, string, bool>> PageTitleMap =
            new Dictionary<string, Func<IWebDriver, string, bool>> {
                {"Home Page", (driver, pageTitle) => new HomePage(driver).Load().PageTitle == pageTitle},
                {"Add User Page", (driver,pageTitle) => new LoginPage(driver).Load().PageTitle == pageTitle},
                {"Add Apprentice Page", (driver,pageTitle) => new ApprenticePage(driver).Load().PageTitle == pageTitle},
                {"Add Apprentice EPA Page", (driver,pageTitle) => new ApprenticeEpaPage(driver).Load().PageTitle == pageTitle},            
            };

        public static bool LoadPageAndCheckTitle(IWebDriver driver, string pageTitle) {
            return PageTitleMap[pageTitle](driver,pageTitle);
        }
    }
}
