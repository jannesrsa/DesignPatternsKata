using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.UnitTests
{
    [TestClass]
    public class CommandUnitTests
    {
        [TestMethod]
        public void ShouldAddNumbersAsText()
        {
            var controller = new Controller();
            IAppCommand addNumbersCommand = new AddNumbersCommand();
            var addCommandReference = controller.AddCommand(addNumbersCommand);
            var expected = "1234";
            controller.GetCommandAt(addCommandReference).Execute(expected);
            Assert.AreEqual(expected, controller.GetBuiltString());
        }
    }
}
