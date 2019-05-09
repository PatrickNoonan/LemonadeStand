using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //has a 
        WeatherAPI GetWeatherAPI2;
        public List<string> weatherOptions;
        public List<string> weatherList;
        public string weatherChoice;
        public string tempChoice;
        public Random RNG;
        public List<string> daysOfWeek;

        //contructor
        public Weather()
        {
            RNG = new Random();
            weatherOptions = new List<string> { "Clear", "Clouds", "Mist", "Fog", "Drizzle", "Rain", "Thunderstorms", "Snow" };
            daysOfWeek = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            GetWeatherAPI2 = new WeatherAPI();
        }

        //does this
        public string DetermineTemp(int day)
        {
            weatherList = GetWeatherAPI2.WeatherReport(day);
            tempChoice = weatherList[0];
            return tempChoice;
        }
        public string DetermineWeather(int day)
        {
            weatherList = GetWeatherAPI2.WeatherReport(day);
            weatherChoice = weatherList[1];
            return weatherChoice;
        }        
        public void DetermineWeekForecast()
        {
            GetWeatherAPI2.ForecastReport();
        }        
    }
}

