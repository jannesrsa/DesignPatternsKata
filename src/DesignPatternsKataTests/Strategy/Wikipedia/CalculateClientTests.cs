using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Strategy.Wikipedia.Tests
{
    [TestClass()]
    public class CalculateClientTests
    {
        [TestMethod()]
        public void CalculateTest_Minus()
        {
            // Arrange
            var calculateClient = new CalculateClient(new Minus());

            // Action
            var actual = calculateClient.Calculate(6, 1);

            // Assert
            Assert.AreEqual(5, actual);
        }

        [TestMethod()]
        public void CalculateTest_Plus()
        {
            // Arrange
            var calculateClient = new CalculateClient(new Plus());

            // Action
            var actual = calculateClient.Calculate(4, 3);

            // Assert
            Assert.AreEqual(7, actual);
        }

        [TestMethod()]
        public void CalculateTest_Minus_Then_Plus()
        {
            // Arrange
            var calculateClient = new CalculateClient(new Minus());
            calculateClient.Strategy = new Plus();

            // Action
            var actual = calculateClient.Calculate(4, 3);

            // Assert
            Assert.AreEqual(7, actual);
        }
    }
}