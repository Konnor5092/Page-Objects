using OpenQA.Selenium;

namespace IPageTest
{
    public class HomePage : BasePage<HomePage> {

        public Control LogOutBtn;
        public Control LogInBtn;

        public override string PageTitle {
            get { return "Home Page"; }
        }

        public HomePage(IWebDriver driver) : base(driver) {

        }

        public override bool EvaluateLoadStatus() {
            return true;
        }
    }
}
