using System.Collections.Generic;
using Head_First_Design_Patterns.ObserverInterfaces;

namespace Head_First_Design_Patterns.ObserverPattern
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }
        
        public void RegisterObserver(Observer o)
        {
            this.observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            int indexOf = this.observers.IndexOf(o);
            if(indexOf >= 0)
            {
                observers.RemoveAt(indexOf);
            }
        }

        public void NotifyObservers()
        {
            this.observers.ForEach(o => o.Update(temperature, humidity, pressure));
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
