using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Singleton.Tests
{
    [TestClass()]
    public class MySingletonClassTests
    {
        [TestMethod()]
        public void MySingletonClass_SomeValue()
        {
            // Arrange
            var first = MySingletonClass.Instance;
            var second = MySingletonClass.Instance;

            // Action
            first.SomeValue++;

            // Assert
            Assert.AreSame(first, second);
            Assert.AreEqual(first.SomeValue, second.SomeValue);

            // Action
            second.SomeValue++;

            // Assert
            Assert.AreEqual(first.SomeValue, second.SomeValue);
        }

        [TestMethod()]
        public void MySingletonClass_SomeValue_Threading()
        {
            var taskList = new List<Task>();
            for (int i = 0; i < 100; i++)
            {
                taskList.Add(Task.Run(() => MySingletonClass_SomeValue()));
            }

            Task.WaitAll(taskList.ToArray());
        }
    }
}