using System.Collections.Generic;

namespace DesignPatternsKata.Observer.Channel9
{
    public interface ISubject
    {
        void RegisterObserver(ICustomObserver observer);

        void UnregisterObserver(ICustomObserver observer);

        IEnumerable<ICustomObserver> Observers { get; }
    }
}