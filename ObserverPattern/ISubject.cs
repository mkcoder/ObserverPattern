namespace ObserverPattern
{
    public interface Subject
    {
        void Subscribe(IObserver observer);
        void UnSubscribe(IObserver observer);
        void Notify();
    }
}