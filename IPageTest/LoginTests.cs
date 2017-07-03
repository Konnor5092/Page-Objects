using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPageTest
{
    class LoginTests
    {
        private LoginPage loginPage { get; }

        public LoginTests(LoginPage loginPage) {
            this.loginPage = loginPage;
        }

        public void Login() {
            loginPage.EnterText(loginPage.Username, "Matt")
                .EnterText(loginPage.Password, "Test");
        }
    }
}
