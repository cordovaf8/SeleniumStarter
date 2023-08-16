using FluentAssertions;
using OpenQA.Selenium;
using SeleniumStarter.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeleniumStarter.Tests.Samples.DemoQA
{
    public class HomePageTests : BaseTest
    {
        [Test]
        public void AddElements()
        {
            Driver.Navigate().GoToUrl(Pages.HomePage.Url);

            Pages.HomePage.ClickAddNTimes(4);

            var deleteElements = Interaction.GetElements(Pages.HomePage.DeleteButton);

            deleteElements.Should().HaveCount(4);

        }

        [Test]
        public void AddElementsThenDeleteThem()
        {
            Driver.Navigate().GoToUrl(Pages.HomePage.Url);

            Pages.HomePage.ClickAddNTimes(4);

            var deleteElements = Interaction.GetElements(Pages.HomePage.DeleteButton);

            deleteElements.Should().HaveCount(4);

            foreach (var element in deleteElements)
            {
                Interaction.ClickElement(element);
            }

            var deleteElementsAfter = Interaction.GetElements(Pages.HomePage.DeleteButton);

            deleteElementsAfter.Should().HaveCount(0);


        }

    }
}
