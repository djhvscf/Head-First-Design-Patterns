
using Head_First_Design_Patterns.ObserverPattern;
using System;

namespace Head_First_Design_Patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Observer Pattern");
            Console.WriteLine("-----------------");
            WeatherStation.Run();
            Console.WriteLine("-----------------");
            WeatherStationHeatIndex.Run();
            Console.WriteLine("-----------------");
        }
    }
}
