using DesignPatternsKata.Memento;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKataTests.Memento.Tests
{
    [TestClass]
    public class MementoUnitTests
    {
        [TestMethod]
        public void ShouldUpdateTheCustomersName()
        {
            // Arrange
            var cust = new Customer { Id = 5, Name = "John Doe" };
            var cmd = new ChangeCustomerCommand(cust);
            var expected = "Billy Bob";

            // Action
            cmd.Execute(expected);

            // Assert
            Assert.AreEqual(expected, cmd.Customer.Name);
        }

        [TestMethod]
        public void ShouldRollBackTheChange()
        {
            // Arrange
            var expectedName = "John Doe";
            var expectedId = 5;
            var cust = new Customer { Id = expectedId, Name = expectedName };
            var cmd = new ChangeCustomerCommand(cust);
            var newName = "Billy Bob";
            cmd.Execute(newName);

            // Action
            cmd.UnExecute();

            // Assert
            Assert.AreEqual(expectedName, cmd.Customer.Name);
            Assert.AreEqual(expectedId, cmd.Customer.Id);
        }
    }
}