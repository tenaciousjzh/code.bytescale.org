using Org.Bytescale.Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Bytescale.Patterns
{
    public class WeatherStation
    {
        public static void Main(string[] args) {
            WeatherObservable weatherReporter = new WeatherObservable();
            WeatherData wd = new WeatherData();
            wd.SetMeasurements(48.0f, .50f, 10.0f);

            CurrentConditionsDisplay display = new CurrentConditionsDisplay();
            using (IDisposable disposable = weatherReporter.Subscribe(display)) {
                weatherReporter.UpdateWeather(wd, false);
                wd = new WeatherData();
                wd.SetMeasurements(105.0f, .89f, 32.0f);
                weatherReporter.UpdateWeather(wd, false);
                wd = new WeatherData();
                wd.SetMeasurements(17.5f, .16f, 12.0f);
                weatherReporter.UpdateWeather(wd, false);
                weatherReporter.CloseAllStationReports();
            }
            
        }
    }
}
