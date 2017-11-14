using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Adapter.Channel9.Tests
{
    [TestClass()]
    public class FlyingSquirrelAdapterTests
    {
        [TestMethod()]
        public void FlyingSquirrelAdapter_Attack()
        {
            // Arrange
            ICharacter rocky = new FlyingSquirrelAdapter(new FlyingSquirrel());
            var expected = 1;

            // Action
            var actual = rocky.Attack();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FlyingSquirrelAdapter_Chase()
        {
            // Arrange
            ICharacter rocky = new FlyingSquirrelAdapter(new FlyingSquirrel());
            var expected = 20;

            // Action
            var actual = rocky.Chase();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FlyingSquirrelAdapter_Flee()
        {
            // Arrange
            ICharacter rocky = new FlyingSquirrelAdapter(new FlyingSquirrel());
            var expected = 20;

            // Action
            var actual = rocky.Flee();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}