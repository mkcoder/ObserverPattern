using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class AbstractSubject : Subject
    {
        private readonly List<IObserver> _observers;

        public AbstractSubject()
        {
            this._observers = new List<IObserver>();
        }

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnSubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            _observers.ForEach(o => o.Update());
        }
    }
}