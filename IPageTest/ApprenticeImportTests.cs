using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPageTest
{
    public class ApprenticeImportTests
    {
        private ApprenticePage apprenticePage { get; }

        public ApprenticeImportTests(ApprenticePage apprenticePage) {
            this.apprenticePage = apprenticePage;
        }

        public ApprenticeImportTests AddApprentice() {
            apprenticePage.EnterText(apprenticePage.ForenameField, "Harry")
                .EnterText(apprenticePage.ForenameField, "Smith");
            return this;
        }

    }
}
