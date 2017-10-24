using PatternsLearning.ObserverPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.ObserverPattern.Concrete_Classes
{
    public class PhoneWeatherViewer : IObserver
    {
        WeatherStation observedWeatherStation;

        public PhoneWeatherViewer(WeatherStation wheaterStation)
        {
            this.observedWeatherStation = wheaterStation;
        }
        public void Update()
        {
            Console.WriteLine("PHONE VIEW : {0}", this.observedWeatherStation.Temperature);
        }
    }
}
