using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.TemplateMethod.Channel9.Tests
{
    [TestClass()]
    public class NewYorkStylePizzaStoreTests
    {
        [TestMethod()]
        public void MakePizzaTest()
        {
            // Arrange
            var expectedName = Guid.NewGuid().ToString();
            var newYorkStylePizza = new NewYorkStylePizzaStore();

            // Action
            newYorkStylePizza.CreatePizzaForDelivery(expectedName);

            // Assert
            StringAssert.Contains(newYorkStylePizza.PizzaForDelivery.Name, expectedName);
        }
    }
}