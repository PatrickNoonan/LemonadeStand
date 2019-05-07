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
        public List<string> DaysOfWeek;

        //contructor
        public Weather()
        {
            RNG = new Random();
            WeatherOptions = new List<string> { "Sunny", "Rainy", "Cloudy", "Cold" };
            DaysOfWeek = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        }

        //does this
        public void DetermineForecast()
        {
            Console.WriteLine("Would you like to get the forecast for the week or a specific day?(day or week or no)");
            string ForecastAnswer = Console.ReadLine().ToLower();
            if (ForecastAnswer == "day")
            {
                DetermineSpecificDayForecast();
            } 
            else if (ForecastAnswer == "week")
            {
                DetermineWeekForecast();
            }
            else
            {
                Console.WriteLine("Onward");
            }
        }
        public void DetermineSpecificDayForecast()
        {
            Console.WriteLine("What day did you want the forecast of?(1-7)");
            int DayToForecast = int.Parse(Console.ReadLine());
            string DaysWeather = DetermineWeather();

            Console.WriteLine($"The Forecast for {DaysOfWeek[DayToForecast-1]} is {DaysWeather}");
            Console.ReadLine();
        }
        public void DetermineWeekForecast()
        {
            Console.WriteLine($"The Forecast for the week will be..");
            string DaysWeather;
            foreach (string day in DaysOfWeek)
            {
                DaysWeather = DetermineWeather();
                Console.WriteLine($"The Forecast for {day} is looking to be {DaysWeather}.");
            }
            Console.ReadLine();
        }

        public string DetermineWeather()
        {
            int index = RNG.Next(WeatherOptions.Count);
            WeatherChoice = WeatherOptions[index];
            return WeatherChoice;
        }
    }
}

