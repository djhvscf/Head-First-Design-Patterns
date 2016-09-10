using Head_First_Design_Patterns.ObserverInterfaces;
using System;

namespace Head_First_Design_Patterns.ObserverPattern
{
    public class StatisticsDisplay : Observer, DisplayElement
    {
        private float maxTemp = 0;
        private float minTemp = 200;
        private float tempSum = 0;
        private int numReadings;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.tempSum = (this.tempSum + temperature);
            this.numReadings++;
            if ((temperature > this.maxTemp))
            {
                this.maxTemp = temperature;
            }

            if ((temperature < this.minTemp))
            {
                this.minTemp = temperature;
            }

            this.Display();
        }

        public void Display()
        {
            Console.WriteLine(("Avg/Max/Min temperature = "
                            + ((this.tempSum / this.numReadings) + ("/"
                            + (this.maxTemp + ("/" + this.minTemp))))));
        }
    }
}
