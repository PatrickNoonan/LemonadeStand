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
        public Recipe TodaysRecipe = new Recipe();
        public List<Customer> CustomerList;
        public string WeatherType;
        public int TodaysVisits;
        public int TodaysPurchases;

        //contructor
        public Day()
        {
            TodaysWeather = new Weather();
            RNG = new Random();
            CustomerList = new List<Customer> { };
        }

        //does this
        public void UpdateWeather()
        {
            WeatherType = TodaysWeather.DetermineWeather();
        }

        public void CheckWeather()
        {
            Console.WriteLine("It is a " + WeatherType + " day today.");
        }

        public void DetermineVisits()
        {
            TodaysVisits = RNG.Next(50, 100);
        }

        public void CustomerVisits()
        {
            for (int i = 0; i < TodaysVisits; i++)
            {
                CustomerList.Add(new Customer());
            }

            Console.WriteLine("The amount of visitors today was " + TodaysVisits);
        }
        public void GlassesPurchased()
        {
            foreach (Customer customer in CustomerList)
            {
                customer.CurrentCustomerChanceToBuy = RNG.Next(150);
                if (customer.WillPurchase(WeatherType) == true)
                {
                    TodaysPurchases++;
                }
            }
            Console.WriteLine("The amount of purchases today was " + TodaysPurchases);
        }
    }
}
