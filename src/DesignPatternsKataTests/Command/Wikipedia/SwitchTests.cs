using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Command.Wikipedia.Tests
{
    [TestClass()]
    public class SwitchTests
    {
        [TestMethod()]
        [Description("Command Pattern | SwitchTest")]
        public void SwitchTest()
        {
            // Arrange
            var light = new Light();

            // Action
            var lightSwitch = HelperMethods.CreateSwitch(light);

            // Assert
            Assert.IsNotNull(lightSwitch);
        }

        [TestMethod()]
        [Description("Command Pattern | CloseTest")]
        public void CloseTest()
        {
            // Arrange
            var light = new Light();
            var lightSwitch = HelperMethods.CreateSwitch(light);

            // Action
            lightSwitch.Open();

            // Assert
            Assert.IsTrue(light.On);
        }

        [TestMethod()]
        [Description("Command Pattern | OpenTest")]
        public void OpenTest()
        {
            // Arrange
            var light = new Light();
            var lightSwitch = HelperMethods.CreateSwitch(light);

            // Action
            lightSwitch.Close();

            // Assert
            Assert.IsFalse(light.On);
        }
    }
}