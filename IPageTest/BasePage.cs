using System;
using OpenQA.Selenium;

namespace IPageTest
{
    public abstract class BasePage<T> : Base where T : BasePage<T> {

        protected IWebDriver Driver;

        protected BasePage(IWebDriver driver) {
            Driver = driver;
        }
        public T Click(Control control) {
            Console.WriteLine("Click");
            return (T)this;
        }

        public T EnterText(Control control, string text) {
            Console.WriteLine(text);
            return (T) this;
        }

        public abstract string PageTitle { get; }
        public abstract bool EvaluateLoadStatus();
    }
}
