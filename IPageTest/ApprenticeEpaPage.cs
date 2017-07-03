using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace IPageTest
{
    public class ApprenticeEpaPage : HomePage
    {
        public Control TextField;
        public Control SubmitBtn;
        public Control SubmitEpa;
        public override string PageTitle {
            get { return "Apprentice EPA Page"; }
        }
        public ApprenticeEpaPage(IWebDriver driver) : base(driver) {
        }
        public override bool EvaluateLoadStatus() {
            return true;
        }
    }
}
