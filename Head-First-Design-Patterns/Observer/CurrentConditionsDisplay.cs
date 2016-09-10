
using Head_First_Design_Patterns.ObserverInterfaces;
using System;

namespace Head_First_Design_Patterns.ObserverPattern
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + this.temperature + "F degrees and " + this.humidity + "% humidity");
        }
    }
}
