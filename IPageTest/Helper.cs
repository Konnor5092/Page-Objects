using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace IPageTest
{
    public static class Helper
    {
        private static T EvaluateLoad<T>(T page, bool condition) {
            if (condition) {
                return page;
            }
            throw new WebDriverException("Unable to load page");
        }

        public static T Load<T>(this T page) where T : HomePage {
            return EvaluateLoad(page, page.EvaluateLoadStatus());
        }

        public static LoginPage Load(this LoginPage page){
            return EvaluateLoad(page, page.EvaluateLoadStatus());
        }
    }
}
