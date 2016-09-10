using System;

namespace Head_First_Design_Patterns.ObserverPattern
{
    public static class WeatherStationHeatIndex
    {
        public static void Run()
        {
            Random rnd = new Random();
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(rnd.Next(), rnd.Next(), rnd.Next());
            weatherData.SetMeasurements(rnd.Next(), rnd.Next(), rnd.Next());
            weatherData.SetMeasurements(rnd.Next(), rnd.Next(), rnd.Next());
        }
    }
}
