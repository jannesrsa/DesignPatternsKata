using System.Collections.Generic;

namespace DesignPatternsKata.Observer.Channel9
{
    public class SportsAggregator : ISubject
    {
        private IList<ICustomObserver> _observers = new List<ICustomObserver>();

        public void RegisterObserver(ICustomObserver observer)
        {
            _observers.Add(observer);
        }

        public void AddGameResult(GameResult gameResult)
        {
            foreach (var observer in _observers)
            {
                observer.AddGameResult(gameResult);
            }
        }
    }
}