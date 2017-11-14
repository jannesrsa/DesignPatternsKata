using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Adapter.Channel9.Tests
{
    [TestClass()]
    public class MooseAdapterTests
    {
        [TestMethod()]
        public void MooseAdapter_Attack()
        {
            // Arrange
            ICharacter bullWinkle = new MooseAdapter(new Moose());
            var expected = 10;

            // Action
            var actual = bullWinkle.Attack();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MooseAdapter_Chase()
        {
            // Arrange
            ICharacter bullWinkle = new MooseAdapter(new Moose());
            var expected = 5;

            // Action
            var actual = bullWinkle.Chase();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MooseAdapter_Flee()
        {
            // Arrange
            ICharacter bullWinkle = new MooseAdapter(new Moose());
            var expected = 5;

            // Action
            var actual = bullWinkle.Flee();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}