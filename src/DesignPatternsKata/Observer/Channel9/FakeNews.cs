using System.Collections.Generic;

namespace DesignPatternsKata.Observer.Channel9
{
    public abstract class FakeNews : ICustomObserver
    {
        public List<GameResult> Results { get; } = new List<GameResult>();

        public void AddGameResult(GameResult gameResult)
        {
            Results.Add(gameResult);
        }
    }
}