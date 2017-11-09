using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Command.Channel9.Tests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        [Description("Command Pattern | ShouldAddNumbersAsText")]
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
        [Description("Command Pattern | ShouldUndoNumbersAsText")]
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
        [Description("Command Pattern | ShouldAddText")]
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
        [Description("Command Pattern | ShouldUndoText")]
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