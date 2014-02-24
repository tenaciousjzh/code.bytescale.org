using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Bytescale.Patterns.Observer
{
    public class WeatherObservable : IObservable<WeatherData>
    {
        private List<IObserver<WeatherData>> _observers;
        private List<WeatherData> _weatherInfo;

        public WeatherObservable() {
            _observers = new List<IObserver<WeatherData>>();
            _weatherInfo = new List<WeatherData>();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (! _observers.Contains(observer)) {
                _observers.Add(observer);

                foreach (WeatherData item in _weatherInfo) {
                    observer.OnNext(item);
                }
            }
            return new WeatherUnsubscriber<WeatherData>(_observers, observer);
        }

        public void UpdateWeather(WeatherData weatherData, bool removeReport) {
            if (removeReport && _weatherInfo.Contains(weatherData))
            {
                _weatherInfo.Remove(weatherData);
            }
            else
            {

                _weatherInfo.Add(weatherData);
                foreach (var observer in _observers)
                {
                    observer.OnNext(weatherData);
                }
            }
        }

        public void CloseAllStationReports() {
            foreach (var observer in _observers) {
                observer.OnCompleted();
            }
            _observers.Clear();
        }

        public List<WeatherData> WeatherInfo { get { return _weatherInfo; } }
    }

    internal class WeatherUnsubscriber<WeatherData> : IDisposable
    {
        private List<IObserver<WeatherData>> _observers;
        private IObserver<WeatherData> _observer;

        internal WeatherUnsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose() {
            if (_observers.Contains(_observer)) {
                _observers.Remove(_observer);
            }
        }
    }
}
