using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace OpenWeatherConsole
{
    internal class OpenWeatherForecast
    {
        private static string ApiKey()
        {
            var ReadJSON = File.ReadAllText("appsettings.json");
            var apiKey = JObject.Parse(ReadJSON).GetValue("APIKey").ToString();
            return apiKey;
        }

        public void cityName(string city)
        {
            var client = new HttpClient();
            string weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey()}&units=imperial";
            var weatherResults = client.GetStringAsync(weatherURL).Result;
            Console.WriteLine(JObject.Parse(weatherResults).GetValue("name").ToString());
        }
        public void AllWeather(string city)
        {
            //call API
            var client = new HttpClient();
            string weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey()}&units=imperial";
            var WeatherResults = client.GetStringAsync(weatherURL).Result;
            var WeatherParse = JObject.Parse(WeatherResults).ToString();

            Console.WriteLine(WeatherParse);
        }

        public void CurrentTemperature(string city)
        {
            var client = new HttpClient();
            string weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey()}&units=imperial";
            var WeatherResults = client.GetStringAsync(weatherURL).Result;
            JObject WeatherParse = JObject.Parse(WeatherResults);
            var temperature = WeatherParse["main"].ToString();
            Console.WriteLine(temperature);
        }
    }
}
