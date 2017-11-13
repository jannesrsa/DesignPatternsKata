using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Observer.Tests
{
    [TestClass()]
    public class RegionNotifyPropertyChangedTests
    {
        [TestMethod()]
        public void SetNameTest()
        {
            // Arrange
            var region = new RegionNotifyPropertyChanged
            {
                Name = Guid.NewGuid().ToString()
            };

            var expected = Guid.NewGuid().ToString();

            var propertyName = default(string);
            PropertyChangedEventHandler handler = (s, e) =>
            {
                propertyName = e.PropertyName;
            };

            region.PropertyChanged += handler;

            // Action
            region.Name = expected;

            // Assert
            Assert.AreEqual(expected, region.Name);
            Assert.AreEqual(nameof(region.Name), propertyName);
        }

        [TestMethod()]
        public void SetNameTest_MultipleHandlers()
        {
            // Arrange
            var region = new RegionNotifyPropertyChanged
            {
                Name = Guid.NewGuid().ToString()
            };

            var expected = Guid.NewGuid().ToString();

            var propertyName = default(string);
            PropertyChangedEventHandler handler = (s, e) =>
            {
                propertyName = e.PropertyName;
            };

            region.PropertyChanged += handler;

            var prePend = Guid.NewGuid().ToString();
            var propertyName2 = default(string);

            PropertyChangedEventHandler handler2 = (s, e) =>
            {
                propertyName2 = prePend + e.PropertyName;
            };

            region.PropertyChanged += handler2;

            // Action
            region.Name = expected;

            // Assert
            Assert.AreEqual(expected, region.Name);
            Assert.AreEqual(nameof(region.Name), propertyName);
            Assert.AreEqual(prePend + nameof(region.Name), propertyName2);
        }
    }
}