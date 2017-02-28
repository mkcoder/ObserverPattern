namespace ObserverPattern
{
    public interface Subject
    {
        void Subscribe(Observer observer);
        void UnSubscribe(Observer observer);
        void Notify();
    }
}