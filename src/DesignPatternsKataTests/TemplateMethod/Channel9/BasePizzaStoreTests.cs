using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DesignPatternsKata.TemplateMethod.Channel9.Tests
{
    [TestClass()]
    public class BasePizzaStoreTests
    {
        [TestMethod()]
        public void CreatePizzaForDeliveryTest()
        {
            // Arrange
            var expectedPizzaName = Guid.NewGuid().ToString();
            var actual = new Pizza(expectedPizzaName);

            var basePizzaStore = new Mock<BasePizzaStore>();
            basePizzaStore
                .Setup(i => i.MakePizza(It.IsAny<string>()))
                .Returns(actual);

            // Action
            basePizzaStore.Object.CreatePizzaForDelivery(expectedPizzaName);

            // Assert
            Assert.AreEqual(expectedPizzaName, actual.Name);
            CollectionAssert.Contains(basePizzaStore.Object.Status, "TakeOrder");
        }
    }
}