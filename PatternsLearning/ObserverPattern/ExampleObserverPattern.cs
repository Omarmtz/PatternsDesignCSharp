using PatternsLearning.ObserverPattern.Concrete_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.ObserverPattern
{
    public class ExampleObserverPattern
    {
        public static void WeatherStationObserverPatternExample()
        {
            WeatherStation station = new WeatherStation();

            ConsoleWheaterViewer consoleWeatherViewer = new ConsoleWheaterViewer(station);
            PhoneWeatherViewer phoneWeatherViewer = new PhoneWeatherViewer(station);

            station.AddObserver(consoleWeatherViewer);
            station.AddObserver(phoneWeatherViewer);

            station.Temperature = 100;
            station.Temperature = 99;
        }
    }
}
