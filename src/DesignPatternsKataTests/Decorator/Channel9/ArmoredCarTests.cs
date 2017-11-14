using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Decorator.Channel9.Tests
{
    [TestClass()]
    public class ArmoredCarTests
    {
        [TestMethod()]
        public void ArmoredCar_ArmoredTest()
        {
            // Arrange
            ICar car = new ArmoredCar(new BaseCar());
            var expected = 100;

            // Action
            var actual = car.Attack();

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ArmoredCar_DriveTest()
        {
            // Arrange
            ICar car = new ArmoredCar(new BaseCar());
            var expected = 100 - 20;

            // Action
            var actual = car.Drive();

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ArmoredCar_DefendTest()
        {
            // Arrange
            ICar car = new ArmoredCar(new BaseCar());
            var expected = 100 + 40;

            // Action
            var actual = car.Defend();

            // Arrange
            Assert.AreEqual(expected, actual);
        }
    }
}