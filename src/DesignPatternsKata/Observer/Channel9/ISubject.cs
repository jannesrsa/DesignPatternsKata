namespace DesignPatternsKata.Observer.Channel9
{
    public interface ISubject
    {
        void NotifyObservers(GameResult gameResult);

        void RegisterObserver(ICustomObserver observer);

        void UnregisterObserver(ICustomObserver observer);
    }
}