using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Decorator.Channel9.Tests
{
    [TestClass()]
    public class AttackCarTests
    {
        [TestMethod()]
        public void AttackCar_AttackCarAttackTest()
        {
            // Arrange
            ICar car = new AttackCar(new AttackCar(new BaseCar()));
            var expected = 100 - 10 - 10;

            // Action
            var actual = car.Attack();

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AttackCar_AttackCarDefendTest()
        {
            // Arrange
            ICar car = new AttackCar(new AttackCar(new BaseCar()));
            var expected = 100 + 30 + 30;

            // Action
            var actual = car.Defend();

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AttackCar_AttackCarDriveTest()
        {
            // Arrange
            ICar car = new AttackCar(new AttackCar(new BaseCar()));
            var expected = 100 - 10 - 10;

            // Action
            var actual = car.Drive();

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AttackCar_AttackTest()
        {
            // Arrange
            ICar car = new AttackCar(new BaseCar());
            var expected = 100 - 10;

            // Action
            var actual = car.Attack();

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AttackCar_DefendTest()
        {
            // Arrange
            ICar car = new AttackCar(new BaseCar());
            var expected = 100 + 30;

            // Action
            var actual = car.Defend();

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AttackCar_DriveTest()
        {
            // Arrange
            ICar car = new AttackCar(new BaseCar());
            var expected = 100 - 10;

            // Action
            var actual = car.Drive();

            // Arrange
            Assert.AreEqual(expected, actual);
        }
    }
}