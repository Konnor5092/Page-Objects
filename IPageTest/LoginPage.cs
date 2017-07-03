using OpenQA.Selenium;

namespace IPageTest
{
    public class LoginPage : BasePage<LoginPage> {

        public Control Username;
        public Control Password;
        public override string PageTitle {
            get { return "Login Page"; }
        }
        public LoginPage(IWebDriver driver) : base(driver) {
        }
        public override bool EvaluateLoadStatus() {
            return true;
        }
    }
}
