using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
	public enum GridState { On, Off }

	public class PowerGrid : IObservable
	{
		private IList<IObserver> observers;
		private GridState gridState { get; set; }

		public PowerGrid()
		{
			this.observers = new List<IObserver>();
			this.gridState = GridState.Off;
		}

		public void Add(IObserver observer)
		{
			this.observers.Add(observer);
		}

		public void Notify()
		{
			foreach (var observer in this.observers)
			{
				observer.Update();
			}
		}

		public void Remove(IObserver observer)
		{
			this.observers.Remove(observer);
		}

		public void ChangeState()
		{
			if (this.gridState == GridState.Off)
			{
				this.gridState = GridState.On;
			}
			else
			{
				this.gridState = GridState.Off;
			}

			Notify();
		}
	}
}
