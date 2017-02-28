using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class AbstractSubject : Subject
    {
        private readonly List<Observer> _observers;

        public AbstractSubject()
        {
            this._observers = new List<Observer>();
        }

        public void Subscribe(Observer observer)
        {
            _observers.Add(observer);
        }

        public void UnSubscribe(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            _observers.ForEach(o => o.Update());
        }
    }
}