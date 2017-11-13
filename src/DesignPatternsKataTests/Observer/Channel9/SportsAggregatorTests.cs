using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsKata.Observer.Channel9.Tests
{
    [TestClass()]
    public class SportsAggregatorTests
    {
        [TestMethod()]
        public void SportsAggregator_AddGameResult()
        {
            // Arrange
            var subject = new SportsAggregator();
            var observer1 = new NewsPaper();
            var observer2 = new RadioStation();
            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);
            var gameResult = new GameResult
            {
                GameDate = DateTime.Now,
                LosingScore = 1,
                LosingTeam = "Mariners",
                WinningScore = 10,
                WinningTeam = "Astros"
            };

            // Action
            subject.AddGameResult(gameResult);

            // Assert
            Assert.AreEqual(1, observer1.Results.Count);
            Assert.AreEqual(1, observer2.Results.Count);
            Assert.AreSame(gameResult, observer1.Results[0]);
            Assert.AreSame(gameResult, observer2.Results[0]);

            // Action
            subject.UnregisterObserver(observer1);
            subject.UnregisterObserver(observer2);

            Assert.IsFalse(subject.Observers.Any());
        }
    }
}