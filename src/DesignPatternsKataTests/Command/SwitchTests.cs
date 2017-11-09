using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsKata.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsKata.Command.Tests
{
    [TestClass()]
    public class SwitchTests
    {
        [TestMethod()]
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