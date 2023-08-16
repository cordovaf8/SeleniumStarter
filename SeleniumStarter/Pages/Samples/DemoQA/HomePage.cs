using OpenQA.Selenium;
using SeleniumStarter.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumStarter.Pages.Samples.DemoQA
{
    public class HomePage : PageBase
    {
        public HomePage(IWebDriver driver, Interaction interaction) : base(driver, interaction) { }

        public readonly String Url = "https://the-internet.herokuapp.com/add_remove_elements/";

        public By AddButton => By.XPath($"//button[contains(text(),'Add Element')]");
        public By DeleteButton => By.XPath($"//button[contains(text(),'Delete')]");

        public void ClickAddNTimes(int n)
        {
            var i = 0;
            while (i != n)
            {
                Interaction.ClickElement(AddButton);
                 ++i;
            }
        }
    }
}
