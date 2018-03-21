using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IObservable
    {
		void Add(IObserver observer);
		void Remove(IObserver observer);
		void Notify();
    }
}
