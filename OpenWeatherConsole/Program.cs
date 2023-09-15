using OpenWeatherConsole;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        OpenWeatherForecast weatherForecast = new OpenWeatherForecast();
        weatherForecast.AllWeather("Birmingham");
        //weatherForecast.CurrentTemperature("Birmingham");
        //weatherForecast.cityName("Birmingham");
    }
}