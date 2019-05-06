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
        public List<string> WeatherOptions;        
        public string WeatherChoice;
        public Random RNG;

        //contructor
        public Weather()
        {
            RNG = new Random();
            WeatherOptions = new List<string> { "Sunny", "Rainy", "Cloudy", "Cold" };
        }

        //does this
        public string DetermineWeather()
        {
            int index = RNG.Next(WeatherOptions.Count);
            WeatherChoice = WeatherOptions[index];
            return WeatherChoice;
        }
    }
}
