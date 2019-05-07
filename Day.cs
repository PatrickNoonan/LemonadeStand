using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //has a 
        public Weather TodaysWeather;
        public Random RNG;
        public string DayOfWeek;
        public string WeatherType;
        public Recipe TodaysRecipe = new Recipe();
        public int TodaysVisits;
        public int TodaysPurchases;

        //contructor
        public Day()
        {
            WeatherType = "Sunny";
            TodaysWeather = new Weather();
            RNG = new Random();
        }

        //does this
        public void UpdateDay()
        {
            Console.WriteLine("Today is " + DayOfWeek);
        }

        public void UpdateWeather()
        {
            WeatherType = TodaysWeather.DetermineWeather();
        }

        public void CheckWeather()
        {
            Console.WriteLine("It is a " + WeatherType + " day today.");
        }

        public void CustomerVisits()
        {
            TodaysVisits = RNG.Next(100);
        }
        public void GlassesPurchased()
        {
            TodaysPurchases = RNG.Next(TodaysVisits);
        }
    }
}
