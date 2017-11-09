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
            var openCommand = new OpenSwitchCommand(light);
            var closeCommand = new CloseSwitchCommand(light);

            // Action
            var lightSwitch = new Switch(openCommand, closeCommand);

            // Assert
            Assert.IsNotNull(lightSwitch);
        }

        [TestMethod()]
        [Description("Command Pattern | CloseTest")]
        public void CloseTest()
        {
            // Arrange
            var light = new Light();
            var openCommand = new OpenSwitchCommand(light);
            var closeCommand = new CloseSwitchCommand(light);
            var lightSwitch = new Switch(openCommand, closeCommand);

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
            var openCommand = new OpenSwitchCommand(light);
            var closeCommand = new CloseSwitchCommand(light);
            var lightSwitch = new Switch(openCommand, closeCommand);

            // Action
            lightSwitch.Close();

            // Assert
            Assert.IsFalse(light.On);
        }
    }
}