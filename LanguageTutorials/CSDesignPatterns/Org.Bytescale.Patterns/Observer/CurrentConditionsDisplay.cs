using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Bytescale.Patterns.Observer
{
    public class CurrentConditionsDisplay : IObserver<WeatherData>
    {
        public void display(float humidity, float temperature, float pressure) {
            Console.WriteLine("Current conditions: " + temperature + "F degrees, " + humidity + "% humidity, and " + pressure + " barometric pressure.");
        }

        public void OnCompleted()
        {
            Console.WriteLine("All stations have reported.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error reporting weather: " + error.Message);
        }

        public void OnNext(WeatherData weatherData)
        {
            display(weatherData.Humidity, weatherData.Temperature, weatherData.Pressure);
        }
    }
}
