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
        public Recipe TodaysRecipe;
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
            TodaysRecipe = new Recipe();
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
            TodaysVisits = RNG.Next(150, 200);
        }

        public void CustomerVisits()
        {
            for (int i = 0; i < TodaysVisits; i++)
            {
                CustomerList.Add(new Customer());
            }

            Console.WriteLine("The amount of visitors today was " + TodaysVisits);
        }
        public void GlassesPurchased(Player player, int DemandValue)
        {
            TodaysPurchases = 0;
            foreach (Customer customer in CustomerList)
            {
                int DemandNum = RNG.Next(DemandValue);
                customer.CurrentCustomerChanceToBuy = DemandNum;
                if ( customer.CheckStock(WeatherType, player.PlayerOneInventory.MakeSureEverythingStocked()) == true)
                {
                    TodaysPurchases++;
                    player.RecountInventory(TodaysRecipe);
                }
            }
            Console.WriteLine("The amount of purchases today was " + TodaysPurchases);
            player.RecountMoney(TodaysRecipe, TodaysPurchases);
        }
    }
}
