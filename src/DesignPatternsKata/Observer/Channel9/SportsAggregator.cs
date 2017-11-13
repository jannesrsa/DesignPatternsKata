using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternsKata.Observer.Channel9
{
    public class SportsAggregator : ISubject
    {
        public List<ICustomObserver> Observers { get; } = new List<ICustomObserver>();

        public void AddGameResult(GameResult gameResult)
        {
            NotifyObservers(gameResult);
        }

        public void NotifyObservers(GameResult gameResult)
        {
            Parallel.ForEach(Observers, i => i.AddGameResult(gameResult));
        }

        public void RegisterObserver(ICustomObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnregisterObserver(ICustomObserver observer)
        {
            if (Observers.Contains(observer))
            {
                Observers.Remove(observer);
            }
        }
    }
}