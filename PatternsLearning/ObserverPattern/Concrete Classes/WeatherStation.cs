using PatternsLearning.ObserverPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.ObserverPattern.Concrete_Classes
{
    public class WeatherStation : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();

        int temp;

        public int Temperature
        {
            get { return this.temp; }
            set
            {
                this.temp = value;
                Notify();
            }
        }

        public void AddObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

    }
}
