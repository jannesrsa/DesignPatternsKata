using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Decorator.Channel9.Tests
{
    [TestClass()]
    public class BaseCarTests
    {
        [TestMethod()]
        public void BaseCar_AttackTest()
        {
            // Arrange
            ICar car = new BaseCar();
            var expected = 100;

            // Action
            var actual = car.Attack();

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BaseCar_DriveTest()
        {
            // Arrange
            ICar car = new BaseCar();
            var expected = 100;

            // Action
            var actual = car.Drive();

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BaseCar_DefendTest()
        {
            // Arrange
            ICar car = new BaseCar();
            var expected = 100;

            // Action
            var actual = car.Defend();

            // Arrange
            Assert.AreEqual(expected, actual);
        }
    }
}