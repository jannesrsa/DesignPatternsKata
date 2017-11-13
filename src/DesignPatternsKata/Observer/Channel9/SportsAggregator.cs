using System.Collections.Generic;

namespace DesignPatternsKata.Observer.Channel9
{
    public class SportsAggregator : ISubject
    {
        private readonly List<ICustomObserver> _observers = new List<ICustomObserver>();

        public IEnumerable<ICustomObserver> Observers { get { return _observers; } }

        public void AddGameResult(GameResult gameResult)
        {
            foreach (var observer in _observers)
            {
                observer.AddGameResult(gameResult);
            }
        }

        public void RegisterObserver(ICustomObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(ICustomObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }
    }
}