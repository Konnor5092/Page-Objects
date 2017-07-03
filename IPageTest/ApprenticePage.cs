using OpenQA.Selenium;

namespace IPageTest
{
    public class ApprenticePage : HomePage {

        public Control ULNField;
        public Control ForenameField;
        public Control SurnameField;
        public Control SubmitBtn;
        public override string PageTitle {
            get { return "Apprentice Page"; }
        }
        public ApprenticePage(IWebDriver driver) : base(driver) {
        }
        public override bool EvaluateLoadStatus() {
            return true;
        }
    }
}
