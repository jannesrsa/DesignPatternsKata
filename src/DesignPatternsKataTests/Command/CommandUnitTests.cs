using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Command.Tests
{
    [TestClass]
    public class CommandTests
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

        [TestMethod]
        public void ShouldUndoNumbersAsText()
        {
            var controller = new Controller();
            var addCommandReference = controller.AddCommand(new AddNumbersCommand());
            var expected = "1234";
            controller.GetCommandAt(addCommandReference).Execute(expected);
            controller.GetCommandAt(addCommandReference).Execute("5678");
            controller.GetCommandAt(addCommandReference).UnExecute();
            Assert.AreEqual(expected, controller.GetBuiltString());
        }

        [TestMethod]
        public void ShouldAddText()
        {
            var controller = new Controller();
            var addCommandReference = controller.AddCommand(new AddTextCommand());
            var text1 = "abc";
            controller.GetCommandAt(addCommandReference).Execute(text1);
            var text2 = "def";
            controller.GetCommandAt(addCommandReference).Execute(text2);
            Assert.AreEqual($"{text1}{text2}", controller.GetBuiltString());
        }

        [TestMethod]
        public void ShouldUndoText()
        {
            var controller = new Controller();
            var addCommandReference = controller.AddCommand(new AddTextCommand());
            var expected = "abc";
            controller.GetCommandAt(addCommandReference).Execute(expected);
            controller.GetCommandAt(addCommandReference).Execute("def");
            controller.GetCommandAt(addCommandReference).UnExecute();
            Assert.AreEqual(expected, controller.GetBuiltString());
        }
    }
}