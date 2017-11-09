using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Command.Wikipedia.Tests
{
    [TestClass()]
    public class EngineTests
    {
        [TestMethod()]
        public void PowerOffTest()
        {
            // Arrange
            var engine = new Engine();
            var engineSwitch = HelperMethods.CreateSwitch(engine);

            // Action
            engineSwitch.Close();

            // Assert
            Assert.IsFalse(engine.Started);
        }

        [TestMethod()]
        public void PowerOnTest()
        {
            // Arrange
            var engine = new Engine();
            var engineSwitch = HelperMethods.CreateSwitch(engine);

            // Action
            engineSwitch.Open();

            // Assert
            Assert.IsTrue(engine.Started);
        }
    }
}