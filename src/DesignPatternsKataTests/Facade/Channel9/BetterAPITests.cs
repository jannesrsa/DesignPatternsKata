using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Facade.Channel9.Tests
{
    [TestClass()]
    public class BetterAPITests
    {
        [TestMethod()]
        public void AddThenMultipleTest()
        {
            // Arrange
            IBetterAPI betterAPI = new BetterAPI();
            var value1 = 4;
            var value2 = 5;
            var expected = value1 * value2;

            // Action
            var actual = betterAPI.AddThenMultiple(value1, value2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddThreeNumbersTest()
        {
            // Arrange
            IBetterAPI betterAPI = new BetterAPI();
            var value1 = 4;
            var value2 = 5;
            var value3 = 9;
            var expected = value1 + value2 + value3;

            // Action
            var actual = betterAPI.AddThreeNumbers(value1, value2, value3);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}